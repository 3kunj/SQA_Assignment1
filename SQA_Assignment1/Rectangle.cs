using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment1
{
    class Rectangle
    {
        private int width;
        private int length;

        public Rectangle()
        {
            width = 1;
            length = 1;
        }

        public Rectangle(int w, int l)
        {
            this.width = w;
            this.length = l;
        }

        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
