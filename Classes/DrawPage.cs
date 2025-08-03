

namespace OnCallScheduler
{
    public class DrawPage
    {
        //takes a Site class, uses it then draws the page with the information from Site
        //do I want this class to send it to the printer or just return the image?

        public Bitmap CreateOnCallLog(Sites site) //only gonna draw one page so no need to make it do anything else
        {
            Bitmap bmp = new Bitmap(850, 1100);
            using Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.White);
            g.DrawRectangle(new Pen(Color.Black), 30, 30, 770, 1040);

            return bmp;
        }

    }
}
