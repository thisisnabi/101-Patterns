using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Model;

namespace Thisisnabi.DesignPattern.Creational.Builder.Reporter.Contracts
{
    public interface IReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        Report GetReport();
    }
}
