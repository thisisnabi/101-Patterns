using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Contracts;
using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Model;

namespace Thisisnabi.DesignPattern.Creational.Builder.Reporter.Implements
{
    public class SimpleReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public void BuildHeader()
        {
            report.Header = "Simple Report Header";
        }

        public void BuildBody()
        {
            report.Body = "Simple Report Body";
        }

        public void BuildFooter()
        {
            report.Footer = "Simple Report Footer";
        }

        public Report GetReport()
        {
            return report;
        }
    }
}
