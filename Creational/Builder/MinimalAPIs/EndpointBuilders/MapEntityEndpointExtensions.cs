namespace Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.EndpointBuilders;

public static class MapEntityEndpointExtensions
{
    internal static LookupEndpoints<TLookupType> EntityEndpoint<TLookupType>(this IEndpointRouteBuilder endpoints)
        where TLookupType : EntityBase
    {
        ArgumentNullException.ThrowIfNull(endpoints);

        var nameOfEntity = typeof(TLookupType).Name;
        var routeOfEntityName = nameOfEntity.ToKebabCase();
        var routeGroup = endpoints.MapGroup(routeOfEntityName).WithTags(nameOfEntity);

        return new LookupEndpoints<TLookupType>(routeGroup);
    }

    internal static IEndpointRouteBuilder MapEntityEndpoints(this IEndpointRouteBuilder endpoints)
    {
        ArgumentNullException.ThrowIfNull(endpoints);

        endpoints.EntityEndpoint<UserType>()
            .WithCreate<CreateUserTypeRequest, CreateUserTypeResponse>()
            .WithUpdate<UpdateUserTypeRequst>()
            .WithDelete()
            .WithGetById<UserTypeResponse>()
            .WithGetAll<UserTypeResponse>();

        return endpoints;
    }
}