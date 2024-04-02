using Thisisnabi.DesignPattern.Creational.Builder.Reporter;
using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Implements;
using Thisisnabi.DesignPattern.Creational.Builder.Reporter.Model;



ReportDirector director = new ReportDirector();


SimpleReportBuilder simpleBuilder = new SimpleReportBuilder();

director.SetBuilder(simpleBuilder);
director.ConstructReport();
Report simpleReport = director.GetReport();


Console.WriteLine(simpleReport.Header);
Console.WriteLine(simpleReport.Body);
Console.WriteLine(simpleReport.Footer);

Console.WriteLine("--------------------------------");


ComplexReportBuilder complexBuilder = new ComplexReportBuilder();

director.SetBuilder(complexBuilder);
director.ConstructReport();
Report complexReport = director.GetReport();


Console.WriteLine(complexReport.Header);
Console.WriteLine(complexReport.Body);
Console.WriteLine(complexReport.Footer);

Console.ReadKey();

