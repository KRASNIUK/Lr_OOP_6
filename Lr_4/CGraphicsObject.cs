using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Lr_4
{
    public abstract class CGraphicsObject : ICGraphicsObject
    {

        public Point this[int i]
        {
            get { return points[i]; }
        }

        public virtual string Show()
        {
            string information =
                $"Класс: {GetType().Name}" +
                $"\nПредки класса {GetType().Name}: ";
            {
                Type type = GetType().BaseType;

                while (type != null)
                {
                    information += type.Name;
                    type = type.BaseType;

                    if (type != null)
                        information += "; ";
                    else
                        information += ".";
                }
            }

            information +=
                 "\n" +
                $"\nТочки (x, y):" +
                $"\n\t({points[0].X}, {points[0].Y})" +
                $"\n\t({points[1].X}, {points[1].Y})" +
                $"\n\t({points[2].X}, {points[2].Y})" +
                $"\n\t({points[3].X}, {points[3].Y})";

            return information;

        }



        public Point[] points { get; protected set; }
        public Point location { get; set; }

    }
}