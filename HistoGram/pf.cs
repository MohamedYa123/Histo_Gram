using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
namespace APP
{
    class pfButton : Button
    {
        Thread th;
        Thread th2;
        public pfButton()
        {
            Invalidate();
            ThreadStart thr = new ThreadStart(draw);
            th = new Thread(thr);
            thr = new ThreadStart(refresh);
            th2 = new Thread(thr);
            // th.Start();
            if (BackColor.B < 70)
                BackColor=Color.FromArgb(255,BackColor.R,BackColor.G,70);
        }

        ~pfButton()
        {
            th.Abort();
        }
        public Boolean bt = true;
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                if (value.B < 70 && bt)
                    value = Color.FromArgb(255, value.R, value.G, 70);
                base.BackColor = value;

            }
        }
        private void refresh()
        {
            Invalidate();
            Pen pe = new Pen(Color.FromArgb(50, cr.R, cr.G, cr.B), 20);
            this.CreateGraphics().DrawLine(pe, new Point(i, 0), new Point(i + 15, Height));
            i++;
            i = (i == Width - 15) ? 0 : i;
            Thread.Sleep(1000);
            
            refresh();
        }
        public void start()
        {
            th.Start();
            th2.Start();
        }
        int i = 0;
        PaintEventArgs p;
        int r = 0;
        Boolean b = false;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath grp = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, Convert.ToInt32(0.3 * Width), Height);
           grp.AddArc(rect, 90, 180);
            rect = new Rectangle(Convert.ToInt32(0.7*Width), 0, Convert.ToInt32(0.3 * Width), Height);
            grp.AddArc(rect, 270, 180);
            rect = new Rectangle(Convert.ToInt32(0.2 * Width), 0, Convert.ToInt32(0.7 * Width), Height);
            grp.AddRectangle(rect);
            grp.AddRectangle(rect);
            //grp.AddEllipse(Convert.ToSingle(0.8 * Width), 0, Convert.ToSingle(0.2 * Width), Height);
            this.Region = new Region(grp);


        }
        private void draw()
        {
             try {
               
                Pen pe = new Pen(Color.FromArgb(50, cr.R, cr.G, cr.B), 20);
                this.CreateGraphics().DrawLine(pe, new Point(i, 0), new Point(i + 15, Height));
                i++;
                i = (i == Width - 15) ? 0 : i;
            }
            catch { }
            Thread.Sleep(50);


            
            draw();
        }
        int c;
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);


            this.Left -=Convert.ToInt32( 0.025 * Width/1.05);
            Width =Convert.ToInt32( 1.05*Width);
            Color crrr = BackColor;

            bt = false;
            BackColor = Color.FromArgb(255, crrr.R, crrr.G, crrr.B + 70);
            bt = true;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Left += Convert.ToInt32(0.025 * Width/1.05);
            Width = Convert.ToInt32(Width / 1.05);
            Color crrr = BackColor;
            bt = false;
            BackColor = Color.FromArgb(255, crrr.R, crrr.G, crrr.B - 70);
            bt = true;
        }

        Color cr;
        public Color GraphicsColor
        {


            get
            {
                return cr;
            }


            set
            {
                cr = value;
                this.Invalidate();
            }
        }

    }
}
