using FluentValidation;
using MapsterMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

internal class LookupEndpoints<TEntity>(RouteGroupBuilder groupBuilder) where TEntity : EntityBase
{
    public LookupEndpoints<TEntity> WithCreate<TRequest, TResponse>()
    {
        groupBuilder.MapPost("/", async Task<Results<Ok<TResponse>, ValidationProblem>>
            ([FromBody] TRequest request,
            [FromServices] AppDbContext dbContext,
            [FromServices] IValidator<TRequest> validator,
            IMapper mapper,
            CancellationToken cancellationToken) =>
        {
            ArgumentNullException.ThrowIfNull(nameof(request));

            var validationResult = validator.Validate(request);

            if (validationResult.IsValid)
            {
                var entity = mapper.Map<TEntity>(request);

                await dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);
                await dbContext.SaveChangesAsync(cancellationToken);

                return TypedResults.Ok(mapper.Map<TResponse>(entity));
            }

            return CreateValidationProblem(validationResult.ToDictionary());
        });

        return this;
    }

    public LookupEndpoints<TEntity> WithUpdate<TRequest>()
    {
        groupBuilder.MapPut("/",
            async Task<Results<Ok, ValidationProblem>>
            (int id, [FromBody] TRequest request,
            [FromServices] AppDbContext dbContext,
            [FromServices] IValidator<TRequest> validator,
            IMapper mapper,
            CancellationToken cancellationToken) =>
            {
                ArgumentNullException.ThrowIfNull(nameof(request));

                var validationResult = validator.Validate(request);

                if (validationResult.IsValid)
                {
                    var requestEntity = mapper.Map<TEntity>(request);
                    var oldEntity = await dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
                    dbContext.Entry(oldEntity).CurrentValues.SetValues(requestEntity);

                    await dbContext.SaveChangesAsync(cancellationToken);

                    return TypedResults.Ok();
                }

                return CreateValidationProblem(validationResult.ToDictionary());
            });

        return this;
    }

    public LookupEndpoints<TEntity> WithDelete()
    {
        groupBuilder.MapDelete("/", async (int id, [FromServices] AppDbContext dbContext, CancellationToken cancellationToken) =>
        {
            try
            {
                var oldEntity = await dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
                dbContext.Remove(oldEntity);
                await dbContext.SaveChangesAsync(cancellationToken);

                return Results.Ok();
            }
            catch (Exception)
            {
                return Results.BadRequest();
            }
        });

        return this;
    }

    public LookupEndpoints<TEntity> WithGetById<TResponse>()
    {
        groupBuilder.MapGet("/{id:guid}", async ([FromRoute] int id,
            [FromServices] AppDbContext dbContext,
            IMapper mapper,
            CancellationToken cancellationToken) =>
        {
            var response = await dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            if (response is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(mapper.Map<TResponse>(response));
        });
        return this;
    }

    public LookupEndpoints<TEntity> WithGetAll<TResponse>()
    {
        groupBuilder.MapGet("/", async ([AsParameters] PagedRequestQuery pagedRequst,
            [FromServices] AppDbContext dbContext,
            IMapper mapper,
            CancellationToken cancellationToken) =>
        {
            var total = await dbContext.Set<TEntity>().CountAsync(cancellationToken);

            var entities = await dbContext.Set<TEntity>()
                                          .ToPage(pagedRequst.Page, pagedRequst.Size)
                                          .ToListAsync(cancellationToken);

            var items = mapper.Map<IList<TResponse>>(entities);

            if (items.IsNullOrEmpty())
            {
                return Results.NoContent();
            }

            return Results.Ok(items.ToPaginatedResponse(pagedRequst.Page, pagedRequst.Size, total));
        });
        return this;
    }

    static ValidationProblem CreateValidationProblem(IDictionary<string, string[]> errors) =>
              TypedResults.ValidationProblem(errors);
}
