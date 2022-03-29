using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkolniKolo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int pozice = 5;
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Red, 3);
            Brush brush = new SolidBrush(Color.Blue);
            graphics.TranslateTransform(0, Height);
            graphics.ScaleTransform(1, -1);
            foreach (miry m in Form1.zaznam.Values)
            {
                Rectangle rectVaha = new Rectangle
                {
                    X = pozice,
                    Y = 400,
                    Width = 25,
                    Height = (m.Vaha * 5)
                };
                graphics.DrawRectangle(pen, rectVaha);
                graphics.FillRectangle(brush, rectVaha);
                pozice= pozice + 25;
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
        }
    }
}
