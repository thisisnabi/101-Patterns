using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Contracts;
using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Model;

namespace Thisisnabi.DesignPattern.Creational.Builder.Reporter.Implements
{
    public class ComplexReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public void BuildHeader()
        {
            report.Header = "Complex Report Header";
        }

        public void BuildBody()
        {
            report.Body = "Complex Report Body";
        }

        public void BuildFooter()
        {
            report.Footer = "Complex Report Footer";
        }

        public Report GetReport()
        {
            return report;
        }
    }
}
