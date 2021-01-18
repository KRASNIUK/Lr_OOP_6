using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lr_4
{
    public class Parallelogram : CGraphicsObject, IParallelogram
    {
        public Parallelogram(Point location, int leftSyte, int downSyte, int h)
        {
            this.location = location;
            this.leftSyte = leftSyte;
            this.downSyte = downSyte;
            this.h = h;

            S = downSyte * h;

            int x = location.X;
            int y = location.Y;
            Point P1 = location;
            Point P2 = new Point(x + downSyte, y);
            Point P3 = new Point(x + downSyte + Convert.ToInt32(Math.Sqrt(leftSyte * leftSyte - h * h)), y - h);
            Point P4 = new Point(x + Convert.ToInt32(Math.Sqrt(leftSyte * leftSyte - h * h)), y - h);

            points = new Point[] { P1, P2, P3, P4 };

        }

        public override string Show()
        {
            string information = base.Show();

            information +=
                $"\n\nleftSyte = {leftSyte}" +
                $"\ndownSyte = {downSyte}" +
                $"\nrightSyte = {leftSyte}" +
                $"\nupSyte = {downSyte}" +
                $"\n" +
                $"\nh = {h}" +
                $"\nS = {S}";



            return information;
        }

        // Операции класса
        public static bool operator ==(Parallelogram member1, Parallelogram member2)
        {
            bool answer = true;

            if (member1.S != member2.S)
            {
                answer = false;
            }
            else if (member1.leftSyte != member2.leftSyte)
            {
                answer = false;
            }
            else if (member1.downSyte != member2.downSyte)
            {
                answer = false;
            }

            return answer;
        }
        public static bool operator !=(Parallelogram member1, Parallelogram member2)
        {
            return !(member1 == member2);
        }
        public static bool Equals(Parallelogram member1, Parallelogram member2)
        {
            bool answer = false;
            if (member1 == member2)
            {
                if (member1.points == member2.points)
                {
                    answer = true;
                }
            }

            return answer;
        }

        // Деструктор
        ~Parallelogram()
        {
            Console.WriteLine("Конец работы оператора тип которого Parallelogram");
        }


        public int h { get; private set; }
        public int S { get; private set; }
        public int leftSyte { get; private set; }
        public int downSyte { get; private set; }
    }
}
