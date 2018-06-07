using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinCosSearch
{
    public partial class Form1 : Form
    {
        private Pen CustomPen;

        ColorDialog ColorD = new ColorDialog();

        Pen GrayPen = new Pen(Color.Gray, 1);
        Pen BlackPen = new Pen(Color.Black, 2);
        Pen RedPen = new Pen(Color.Red, 2);

        Graphics g;
        Bitmap Canvas;

        float xalg, xlopp, dx, yalg, ylopp, dy, xpoint, ypoint;

        int Yn = 30;
        int Xn = 40;

        public Form1()
        {
            InitializeComponent();

            Canvas = new Bitmap(TAPBxCanvas.Size.Width, TAPBxCanvas.Size.Height);
            g = Graphics.FromImage(Canvas); //Graphics.FromHwnd(TAPBxCanvas.Handle);

            TAPBxCanvas.Image = Canvas;

            xalg = (float)(-2 * Math.PI);
            xlopp = (float)(2 * Math.PI);

            dx = (float)(Math.PI / 2);
            dy = 1;

            yalg = -3;
            ylopp = 3;

            CustomPen = new Pen(Color.Red, 2);

            xpoint = TAPBxCanvas.Width / (xlopp - xalg);
            ypoint = TAPBxCanvas.Height / (ylopp - yalg);
        }

        private void TABSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFD = new SaveFileDialog();

            SaveFD.Title = "Save Dialog";
            SaveFD.Filter = "Bitmap Images (*.bmp) | *.bmp|All files (*.*)|*.*";
            SaveFD.ShowDialog();

            try
            {
                Canvas.Save(SaveFD.FileName);
                MessageBox.Show(caption: "Saved", text: "Saved Succesfully", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(text: error.Message);
            }
        }

        private void SINCOSTANCTG_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AddGraph()
        {
            float x1 = (float)TAPBxCanvas.Width / 40;
            float y1 = (float)TAPBxCanvas.Height / 30;

            g.DrawLine(BlackPen, 0, TAPBxCanvas.Height / 2, TAPBxCanvas.Width, TAPBxCanvas.Height / 2);
            g.DrawLine(BlackPen, TAPBxCanvas.Width / 2, 0, TAPBxCanvas.Width / 2, TAPBxCanvas.Height);


            for (int ix = 0; ix <= Xn; ix++)
            {
                if (ix % 5 == 0)
                {
                    g.DrawLine(BlackPen, ix * x1, (TAPBxCanvas.Height / 2) + 10, ix * x1, (TAPBxCanvas.Height / 2) - 10);
                }
                else
                {
                    g.DrawLine(BlackPen, ix * x1, (TAPBxCanvas.Height / 2) + 5, ix * x1, (TAPBxCanvas.Height / 2) - 5);
                }
            }

            for (int iy = 0; iy <= Yn; iy++)
            {
                if (iy % 5 == 0)
                {
                    g.DrawLine(BlackPen, (TAPBxCanvas.Width / 2) + 10, iy * y1, (TAPBxCanvas.Width / 2) - 10, iy * y1);
                }
                else
                {
                    g.DrawLine(BlackPen, (TAPBxCanvas.Width / 2) + 5, iy * y1, (TAPBxCanvas.Width / 2) - 5, iy * y1);
                }
            }


            GrayPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            for (double x = 0; x < TAPBxCanvas.Width; x += dx)
            {
                g.DrawLine(GrayPen, (int)(x * xpoint), 0, (int)(x * xpoint), TAPBxCanvas.Height);
            }

            for (double y = 0; y < TAPBxCanvas.Height; y += dy)
            {
                g.DrawLine(GrayPen, 0, (int)(y * ypoint), TAPBxCanvas.Width, (int)(y * ypoint));
            }
            TAPBxCanvas.Image = Canvas;
        }

        private double F1(double x)
        {
            double y = 0;

            int a1 = Convert.ToInt32(SINCOSTANCTG.Text);
            if (firstPlus.Text == "-") a1 = -a1;
            y += a1 * Math.Sin(x);

            int a2 = Convert.ToInt32(TATBxCOS.Text);
            if (secondPlus.Text == "-") a2 = -a2;
            y += a2 * Math.Cos(x);

            return y;

        }

        private void DrawPoints()
        {
            float nxx = (float)xlopp - (float)xalg;
            float nyy = (float)ylopp - (float)yalg;

            float dx = (float)TAPBxCanvas.Width / nxx;
            float dy = (float)TAPBxCanvas.Height / nyy;

            int nx0 = TAPBxCanvas.Width / 2;
            int ny0 = TAPBxCanvas.Height / 2;

            float x1 = (float)xalg;
            float y1 = (float)F1(x1);

            for (float x2 = (float)xalg; x2 <= xlopp; x2 += 0.01F)
            {
                float y2 = (float)F1(x2);
                float y2y1 = Math.Abs(y1 * dy) + Math.Abs(y2 * dy);
                if (y2y1 < TAPBxCanvas.Height)
                {
                    g.DrawLine(CustomPen, (x1 * dx + nx0), (ny0 - y1 * dy), (x2 * dx + nx0), (ny0 - y2 * dy));
                    x1 = x2;
                    y1 = y2;

                }
                else
                {
                    g.DrawLine(CustomPen, (x1 * dx + nx0), (ny0 - y1 * dy), (x2 * dx + nx0), (ny0 - y2 * dy));
                    x1 = x2;
                    y1 = y2;
                }
                TAPBxCanvas.Image = Canvas;
            }
        }

        private void TALPlusMinus_Click(object sender, EventArgs e)
        {
            Label symbol = (Label)sender;
            if (symbol.Text == "+")
            {
                symbol.Text = "-";
            }
            else
            {
                symbol.Text = "+";
            }
        }

        private void TABTeljed_Click(object sender, EventArgs e)
        {
            AddGraph();

        }

        private void TABJoonista_Click(object sender, EventArgs e)
        {


            DrawPoints();


        }

        private void TABColor_Click(object sender, EventArgs e)
        {

            if (ColorD.ShowDialog() == DialogResult.OK)
            {
                ColorL.BackColor = ColorD.Color;
                CustomPen.Color = ColorD.Color;
            }
            else
            {
                ColorL.BackColor = Color.WhiteSmoke;
            }

        }

        private void TABClear_Click(object sender, EventArgs e)
        {
            Canvas = null;
            TAPBxCanvas.Image = Canvas;
            Canvas = new Bitmap(TAPBxCanvas.Width, TAPBxCanvas.Height);
            g = Graphics.FromImage(Canvas);

        }
    }
}
