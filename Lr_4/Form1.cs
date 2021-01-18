using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        

            isDrowParallelogram = -1;
            buttonInformation1.Enabled = false;
            parallelogram = new Parallelogram(location, 100, 50, 80);
            trapezoid = new Trapezoid(location, 150, 50, 60, 30);

            //Show result working overload "==" and method "Equals". Each classes.
            {
                Parallelogram parallelogram2 = new Parallelogram(new Point(12, 5), 100, 50, 80);
                Console.WriteLine($"\nparallelogram1 == parallelogram2 -> {parallelogram == parallelogram2}");
                Console.WriteLine($"Equals(parallelogram1, parallelogram2) -> {Equals(parallelogram, parallelogram2)}");
            }
            {
                Trapezoid trapwzoid2 = new Trapezoid(new Point(12, 5), 150, 50, 60, 30);
                Console.WriteLine($"\ntrapezoid1 == trapwzoid2 -> {trapezoid == trapwzoid2}");
                Console.WriteLine($"Equals(trapezoid1, trapwzoid2) -> {Equals(trapezoid, trapwzoid2)}");
            }
        }

      
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrowParallelogram != -1)
            {
                Pen pen = new Pen(Color.Black, 2);

                Point[] arr;
                arr = (isDrowParallelogram == 1) ? parallelogram.points : trapezoid.points;

                e.Graphics.DrawLine(pen, arr[0], arr[3]);
                e.Graphics.DrawLines(pen, arr);
            }
        }

        private void buttonShowParallelogram_Click(object sender, EventArgs e)
        {
            isDrowParallelogram = 1;
            pictureBox1.Visible = false;
            pictureBox1.Visible = true;


            buttonShowParallelogram.Enabled = false;
            buttonShowTrapezoid.Enabled = true;

            buttonInformation1.Enabled = true;
        }
        private void buttonShowTrapezoid_Click(object sender, EventArgs e)
        {
            isDrowParallelogram = 0;
            pictureBox1.Visible = false;
            pictureBox1.Visible = true;

            buttonShowParallelogram.Enabled = true;
            buttonShowTrapezoid.Enabled = false;

            buttonInformation1.Enabled = true;
        }
        private void buttonInformation_Click(object sender, EventArgs e)
        {
            string information = "";
            switch (isDrowParallelogram){
                case 0:
                    information = trapezoid.Show();
                    break;
                case 1:
                    information = parallelogram.Show();
                    break;
            }
            MessageBox.Show(information, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Для того чтобы менялась картинка в pictureBox1
        // -1 - нечего 
        // 0 - трапеция
        // 1 - паралелограмм
        int isDrowParallelogram { get; set; } 
        
        Parallelogram parallelogram { get; set; }
        Trapezoid trapezoid { get; set; }

        
    }
}
