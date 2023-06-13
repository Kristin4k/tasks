using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class PerspectiveTransformer : ITransformer<PerspectiveParameters>
    {
        double N { get; set; }

        public Size Size { get; private set; }

        public void Initialize(Size size, PerspectiveParameters parameters)
        {
            N = (parameters.NInPerents) / 100;
            Size = size;
        }

        public Point? MapPoint(Point point)
        {
            point = new Point(point.X, point.Y);
            var x = (int)(point.X);
            var y = (int)(point.Y);

            double midX = Size.Width / 2.0;
            double factor = 1 - ((1-N) * point.Y / Size.Height);

            x = (int)(midX +  (point.X - midX)/ factor);

            if (x < 0 || x >= Size.Width)
                return null;

            return new Point(x, y);
        }
    }
}


