using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lr_4
{
    
    
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

            
            int x = pictureBox1.Width / 4;
            int y = pictureBox1.Height * 3 / 4;
            Point location = new Point(x, y);
                        

            figures = new ArrayList();

            figures.Add(new Parallelogram(location, 100, 50, 80));
            figures.Add(new Trapezoid(location, 150, 50, 60, 30));
            figures.Add(new Parallelogram(new Point(location.X - 100, location.Y - 100), 100, 50, 80));
            figures.Add(new Trapezoid(location, 100, 50, 50, 30));
        }

      
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
                Pen pen = new Pen(Color.Black, 2);

                Point[] arr = ((ICGraphicsObject)figures[Counter]).points;

                e.Graphics.DrawLine(pen, arr[0], arr[3]);
                e.Graphics.DrawLines(pen, arr);
            
        }

        
        
        private void buttonInformation_Click(object sender, EventArgs e)
        {
            string information = "";
            
                
            information = ((ICGraphicsObject)figures[Counter]).Show();
                    
                
            information = ((ICGraphicsObject)figures[Counter]).Show();
                    
            
            MessageBox.Show(information, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNextFigure_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.Visible = true;

            Counter++;
            if (Counter >= figures.Count)
            {
                Counter = 0;
            }

        }

        int Counter;
        ArrayList figures;

        
    }
}
