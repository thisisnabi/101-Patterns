using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Contracts;
using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Model;

namespace Thisisnabi.DesignPattern.Creational.Builder.Reporter
{
    public class ReportDirector
    {
        private IReportBuilder builder;

        public void SetBuilder(IReportBuilder builder)
        {
            this.builder = builder;
        }

        public Report GetReport()
        {
            return builder.GetReport();
        }

        public void ConstructReport()
        {
            builder.BuildHeader();
            builder.BuildBody();
            builder.BuildFooter();
        }
    }
}
