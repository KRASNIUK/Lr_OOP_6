using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lr_4
{
    public interface ICGraphicsObject
    {
        Point[] points { get; }
        string Show();
    }
}