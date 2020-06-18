using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMap.Models
{
    public class Line
    {
        public Point BeginPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public Line()
        {

        }
        public void Draw(Graphics e)
        {
            using (Pen pen = new Pen(Color, Width))
            {
                e.DrawLine(pen, BeginPoint, EndPoint);
            }
        }
    }
}
