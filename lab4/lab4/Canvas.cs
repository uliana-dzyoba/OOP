using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Canvas
    {
        //додано фігури всіх типів
        public List<Triangle> triangles = new List<Triangle>();
        public List<Circle> circles = new List<Circle>();
        public List<Rectangle> rectangles = new List<Rectangle>();
        public void WriteTriangles()
        {
            foreach(Triangle t in triangles)
            {
                t.PrintInfo();
            }
        }

        public void WriteCircles()
        {
            foreach (Circle c in circles)
            {
                c.PrintInfo();
            }
        }

        public void WriteRectangles()
        {
            foreach (Rectangle r in rectangles)
            {
                r.PrintInfo();
            }
        }

        public void WriteShapes()
        {
            //використання вже існуючих функцій
            WriteCircles();
            WriteRectangles();
            WriteTriangles();
        }
    }
}
