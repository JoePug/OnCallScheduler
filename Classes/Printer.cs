using System.Drawing;
using System.Drawing.Printing;

namespace OnCallScheduler
{
    public class Printer
    {
        private Bitmap bitmap;
        private PrinterSettings printerSettings;
        PrintDialog dialog = new PrintDialog();
        int numOfCopies = 0;

        public Printer(Bitmap bmp, PrinterSettings settings = null)
        {
            bitmap = bmp;
            printerSettings = settings ?? SetPrinter();
            numOfCopies = printerSettings.Copies;
        }

        public PrinterSettings SetPrinter()
        {
            dialog.ShowDialog();
            return dialog.PrinterSettings;
        }

        public void Print()
        {
            int currentPage = 0;
            var printDoc = new PrintDocument();
            printDoc.PrinterSettings = printerSettings;
            printDoc.PrinterSettings.Copies = 1;
            printDoc.DocumentName = "On-Call_Log";

            printDoc.PrintPage += (sender, e) =>
            {
                e.Graphics?.DrawImage(bitmap, e.MarginBounds);
                currentPage++;
                e.HasMorePages = currentPage < numOfCopies;
            };

            printDoc.Print();
        }
    }
}
/*
        // X axis is 30 to 800
        // Y axis is 30 to 1030   

        private PrintDocument pd = new PrintDocument();
        private Graphics g;

        private IForm DocToPrint;

        PrintDialog dialog = new PrintDialog();
        PrinterSettings printerSettings = new PrinterSettings();
        
        public void SetPrinter()
        {
            dialog.ShowDialog();
            printerSettings = dialog.PrinterSettings;
        }

        public string GetPrinterName()
        {
            return printerSettings.PrinterName;
        }

        public void PrintPage(IForm doc)
        {
            DocToPrint =  doc;
            DoSomePrinting();
        }

        private void DoSomePrinting()
        {
            //Create a PrintDocument object
            PrintDocument pd = new PrintDocument();

            //Add PrintPage event handler
            pd.PrintPage += new PrintPageEventHandler(this.PrintHere);
            pd.PrinterSettings = printerSettings;  //makes sure the selected printer is the one used.    

            DocToPrint.PrintSettings(ref pd);

            pd.Print();
        }

        private void PrintHere(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object
            g = ppeArgs.Graphics;

            DocToPrint.GetPrinter(this); //to spawn a doc from within a doc using the same printer
            
            DocToPrint.PrintNow(ref g);

            ppeArgs.HasMorePages = DocToPrint.AnotherPage();
        }
*/