using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lr_4
{
    public class Trapezoid : CGraphicsObject, ITrapezoid
    {
        public Trapezoid(Point location, int downBase, int rightSyte, int leftSyte, int h)
        {
            this.location = location;
            this.downBase = downBase;
            this.rightSyte = rightSyte;
            this.leftSyte = leftSyte;
            this.h = h;

            upBase = downBase - Convert.ToInt32(Math.Sqrt(rightSyte * rightSyte - h * h)) - Convert.ToInt32(Math.Sqrt(leftSyte * leftSyte - h * h));
            S = (Convert.ToInt32(Math.Sqrt(rightSyte * rightSyte - h * h)) * h) / 2 +
                h * upBase +
                (Convert.ToInt32(Math.Sqrt(leftSyte * leftSyte - h * h)) * h) / 2;

            int x = location.X;
            int y = location.Y;
            Point P1 = location;
            Point P2 = new Point(x + Convert.ToInt32(Math.Sqrt(rightSyte * rightSyte - h * h)), y - h);
            Point P3 = new Point(x + downBase - Convert.ToInt32(Math.Sqrt(leftSyte * leftSyte - h * h)), y - h);
            Point P4 = new Point(x + downBase, y);

            points = new Point[] { P1, P2, P3, P4 };
        }

        public override string Show()
        {
            string information = base.Show();

            information +=
                $"\n\ndownBase = {downBase}" +
                $"\nupBase = {upBase}" +
                $"\nleftSyte = {leftSyte}" +
                $"\nrightSyte = {rightSyte}" +
                $"\n" +
                $"\nh = {h}" +
                $"\nS = {S}";

            return information;
        }
        // 
        // == <- If all sytes are same
        //
        public static bool operator ==(Trapezoid member1, Trapezoid member2)
        {
            bool isEquals = true;
            if (member1.downBase != member2.downBase)
            {
                isEquals = false;
            }
            else if (member1.rightSyte == member2.rightSyte)
            {
                isEquals = false;
            }
            else if (member1.leftSyte == member2.leftSyte)
            {
                isEquals = false;
            }
            else if (member1.h == member2.h)
            {
                isEquals = false;
            }

            return isEquals;
        }
        public static bool operator !=(Trapezoid member1, Trapezoid member2)
        {
            return !(member1 == member2);
        }
        //
        // Equals <- If all properties are same
        //
        public static bool Equals(Trapezoid member1, Trapezoid member2)
        {
            bool isEquals = false;
            if (member1 == member2)
            {
                if (member1.points == member2.points)
                {
                    isEquals = true;
                }
            }

            return isEquals;
        }

        ~Trapezoid()
        {
            Console.WriteLine("\nTrapezoid dead");
        }

        public int downBase { get; private set; }
        public int rightSyte { get; private set; }
        public int leftSyte { get; private set; }
        public int h { get; private set; }

        public int upBase { get; private set; }
        public int S { get; private set; }
    }
}