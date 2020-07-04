using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControlLibrary
{
    public partial class AnalogClock : UserControl
    {
        float[] sin = new float[360];
        float[] cos = new float[360];

        [Category("Appearance")]
        [DefaultValue("Луганск")]
        [DisplayName("CityName")]
        public string SityName { get; set; } = "Луганск";
        public AnalogClock()
        {
            InitializeComponent();
        }

        private void AnalogClock_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 360; i++)
            {
                sin[i] = (float)Math.Sin(i * Math.PI / 180.0);
                cos[i] = (float)Math.Cos(i * Math.PI / 180.0);
            }
        }

        private void AnalogClock_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            int baseRadius = (ClientSize.Width > ClientSize.Height ?
                ClientSize.Height : ClientSize.Width) / 2 - 20;

            PointF centerPoint = new PointF(
                ClientSize.Width / 2.0F, ClientSize.Height / 2.0F);

            gr.DrawEllipse(new Pen(Color.Blue),
                centerPoint.X - baseRadius,
                centerPoint.Y - baseRadius,
                baseRadius * 2, baseRadius * 2);

            for (int i = 1; i < 13; i++)
            {
                gr.DrawLine(new Pen(Color.Blue, 1),
                    new PointF(
                        baseRadius * cos[(i * 30) % 360] + centerPoint.X,
                        baseRadius * sin[(i * 30) % 360] + centerPoint.Y),
                    new PointF(
                        (baseRadius - 10) * cos[(i * 30) % 360] + centerPoint.X,
                        (baseRadius - 10) * sin[(i * 30) % 360] + centerPoint.Y)
                        );
                string str = Convert.ToString(i);
                SizeF size = gr.MeasureString(str, this.Font);

                gr.DrawString(str, this.Font, Brushes.Blue,
                    (baseRadius + 10) * cos[(i * 30 + 270) % 360] + centerPoint.X - size.Width / 2,
                    (baseRadius + 10) * sin[(i * 30 + 270) % 360] + centerPoint.Y - size.Height / 2);
            }

            DateTime dt = DateTime.Now;


            DrawArrow(gr, new Pen(Color.Red, 2), baseRadius - 10, dt.Second * 6);
            DrawArrow(gr, new Pen(Color.Green, 4), baseRadius - 20, dt.Minute * 6);
            DrawArrow(gr, new Pen(Color.Blue, 6), baseRadius - 30, dt.Minute / 2 + dt.Hour % 12 * 30);

            Font font = new Font(this.Font.FontFamily, 10, FontStyle.Bold);

            SizeF cityNameSize = gr.MeasureString(SityName, font);
            gr.DrawString(SityName, font, Brushes.Red,
                new PointF(centerPoint.X - cityNameSize.Width / 2.0F,
                centerPoint.Y - cityNameSize.Height - 20));
        }

        void DrawArrow(Graphics gr, Pen pen, int len, int angle)
        {
            PointF centerPoint = new PointF(
                ClientSize.Width / 2.0F, ClientSize.Height / 2.0F);

            gr.DrawLine(pen,
                centerPoint, new PointF(
                    len * cos[(angle + 270) % 360] + centerPoint.X,
                    len * sin[(angle + 270) % 360] + centerPoint.Y));
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
