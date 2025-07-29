using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnCallScheduler
{
    public class Printer
    {

    }
}
/*
 using System.Drawing;
using System.Drawing.Printing;

public class BitmapPrinter
{
    private Bitmap bitmap;
    private PrinterSettings printerSettings;

    public BitmapPrinter(Bitmap bmp, PrinterSettings settings = null)
    {
        bitmap = bmp;
        printerSettings = settings ?? new PrinterSettings(); // fallback to default if not provided
    }

    public void Print()
    {
        var printDoc = new PrintDocument();
        printDoc.PrinterSettings = printerSettings;
        printDoc.PrintPage += (sender, e) =>
        {
            e.Graphics.DrawImage(bitmap, e.MarginBounds);
        };
        printDoc.Print();
    }
}

Bitmap rendered = new MyBitmapGenerator().CreateDocumentImage();
var printer = new BitmapPrinter(rendered);
printer.Print();



*/


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