using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // hold values for initial design and displays them  

            Graphics g = this.CreateGraphics();

            Font drawfont = new Font("Baskerville Old Face", 50, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            Pen orangePen = new Pen(Color.Orange, 5);
            SolidBrush orangeBrush = new SolidBrush(Color.Black);
           
            g.Clear(Color.Black);

            g.DrawString("Trick", drawfont, drawBrush, 120, 100);
            g.DrawString("Or", drawfont, drawBrush, 150, 200);
            g.DrawString("Treat", drawfont, drawBrush, 120, 300);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 

            Graphics g = this.CreateGraphics();

            Font drawfont = new Font("Baskerville Old Face", 50, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            Pen orangePen = new Pen(Color.Orange, 5);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Pen darkOrangePen = new Pen(Color.DarkOrange);
            SolidBrush darkOrangeBrush = new SolidBrush(Color.DarkOrange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            g.Clear(Color.Black);

            g.DrawString("Happy", drawfont, drawBrush, 115, 100);
            g.DrawString("Halloween", drawfont, drawBrush, 67, 200);

            g.FillEllipse(orangeBrush, 130, 405, 55, 95);
            g.FillEllipse(darkOrangeBrush, 140, 400, 50, 105);
            g.FillEllipse(orangeBrush, 155, 395, 45, 115);
            g.FillEllipse(orangeBrush, 200, 405, 55, 95);
            g.FillEllipse(darkOrangeBrush, 195, 400, 50, 105);
            g.FillEllipse(orangeBrush, 175, 395, 55, 115);
            g.FillEllipse(darkOrangeBrush, 170, 390, 45, 125);

            g.FillPie(blackBrush, 140, 395, 45, 45, 60, 55);
            g.FillPie(blackBrush, 190, 395, 45, 45, 60, 55);
            g.FillEllipse(blackBrush, 145, 460, 100, 25);


        }
    }
}
