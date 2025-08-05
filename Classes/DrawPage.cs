

namespace OnCallScheduler
{
    public class DrawPage : IDisposable
    {
        //takes a Site class, uses it then draws the page with the information from Site
        int x = 0;
        int y = 0;
        Bitmap bmp;
        Graphics g;
        Brush brush = Brushes.Black;
        Font theFont = new Font("Comic Sans MS", 16, FontStyle.Bold | FontStyle.Underline);
        string text = "ON CALL  SCHEDULE";
        Sites? site;

        public DrawPage()
        {
            bmp = new Bitmap(850, 1100);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
        }

        public Bitmap CreateOnCallLog(Sites _site) //only gonna draw one page so no need to make it do anything else
        {  
            site = _site;

            g.DrawRectangle(new Pen(Color.Black), 30, 30, 750, 1000); //Temp Box - Draw within this box to be safe with most printers

            WriteData();

            return (Bitmap)bmp.Clone();
        }

        private void WriteData()
        {
            WriteTopPart();
            WriteFifteenDates();

            WriteBottomLine();
        }

        private void WriteTopPart()
        {
            x = 405;
            y = 30;
            g.DrawString(text, theFont, brush, x - (g.MeasureString(text, theFont).Width / 2), y);

            y += (int)g.MeasureString(text, theFont).Height;
            text = site.SiteName.ToUpper();
            g.DrawString(text, theFont, brush, x - (g.MeasureString(text, theFont).Width / 2), y);

            y += (int)g.MeasureString(text, theFont).Height;
            text = site.Year.ToString();

            theFont = new Font("Comic Sans MS", 14, FontStyle.Bold);
            g.DrawString(text, theFont, new SolidBrush(Color.FromArgb(0x00, 0x2F, 0x6C)), // close enough to original
                                    x - (g.MeasureString(text, theFont).Width / 2), y);
        }

        private void WriteFifteenDates()
        {
            x = 30;
            y = 180;
            theFont = new Font("Comic Sans MS", 15, FontStyle.Bold);

            text = "April 4th - April 10th - Sandy O'Connell";

            for (int i = 0; i < 15; i++)
            {
                g.DrawString(text, theFont, brush, x, y);
                y += 55;
            }

        }

        private void WriteBottomLine()
        {
            //Todo - return if comment is not wanted
            x = 405;
            y = 1010;
            text = site.CommentToPrint;
            theFont = new Font("Comic Sans MS", 12, FontStyle.Bold);

            g.DrawString(text, theFont, brush, x - (g.MeasureString(text, theFont).Width / 2), y);

        }

        public void Dispose()
        {
            g?.Dispose();
            bmp?.Dispose();
        }
    }
}
