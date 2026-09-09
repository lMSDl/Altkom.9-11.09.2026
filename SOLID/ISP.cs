namespace SOLID.I
{
    interface IExcelExporter
    {
        void ToExcel();
    }

    interface IPdfExporter
    {
        void ToPdf();
    }

    class Report : IExcelExporter, IPdfExporter
    {
        public void ToPdf()
        {
            Console.WriteLine("Exporting report to PDF...");
        }
        public void ToExcel()
        {
            Console.WriteLine("Exporting report to Excel...");
        }
    }

    class Poem : IPdfExporter
    {
        public void ToPdf()
        {
            Console.WriteLine("Exporting poem to PDF...");
        }
        /*public void ToExcel()
        {
            throw new NotImplementedException("Poem cannot be exported to Excel.");
        }*/
    }
}
