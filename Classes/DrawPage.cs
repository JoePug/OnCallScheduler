

namespace OnCallScheduler
{
    public class DrawPage : IDisposable
    {
        //takes a Site class, uses it then draws the page with the information from Site
        int x = 0;
        int y = 0;
        Bitmap bmp;
        Graphics g;
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

            g.DrawRectangle(new Pen(Color.Black), 10, 10, 830, 1080); //Test line to draw a box on the page

            return (Bitmap)bmp.Clone();
        }

        public void Dispose()
        {
            g?.Dispose();
            bmp?.Dispose();
        }

    }
}
