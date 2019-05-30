using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "";
            string value2 = "";
            int width = 0;

            int length = 0;
            String choice;
            int select = 0;
            int answer = 0;

            do
            {
                Console.WriteLine("Please Enter Width:");
                value1 = Console.ReadLine();

                if (Int32.TryParse(value1, out int w) || w > 0)
                {
                    width = w;
                }
                else
                {
                    Console.WriteLine("Invalid width");
                }
            }
            while (!Int32.TryParse(value1, out int w1) || !(w1 > 0));

            do
            {
                Console.WriteLine("Please Enter length:");
                value2 = Console.ReadLine();

                if (Int32.TryParse(value2, out int l) || l > 0)
                {
                    length = l;
                }
                else
                {
                    Console.WriteLine("Invalid length");
                }
            }
            while (!Int32.TryParse(value2, out int l1) || !(l1 > 0));

            do
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                choice = Console.ReadLine();

                if (Int32.TryParse(choice, out int c) || c > 0)
                {
                    select = c;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Rectangle r = new Rectangle(width, length);

                switch (select)
                {
                    case 1:

                        answer = r.GetLength();
                        Console.WriteLine("Length is :" + answer);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Please Enter new length:");
                            value2 = Console.ReadLine();

                            if (Int32.TryParse(value2, out int l) || l > 0)
                            {
                                length = l;
                            }
                            else
                            {
                                Console.WriteLine("Invalid length");
                            }
                        }
                        while (!Int32.TryParse(value2, out int l1) || !(l1 > 0));
                        answer = r.SetLength(length);
                        Console.WriteLine("New length is :" + answer);
                        break;
                    case 3:
                        //Rectangle r = new Rectangle(width, length);
                        answer = r.GetWidth();
                        Console.WriteLine("Width is :" + answer);
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Please Enter new width:");
                            value2 = Console.ReadLine();

                            if (Int32.TryParse(value2, out int w) || w > 0)
                            {
                                width = w;
                            }
                            else
                            {
                                Console.WriteLine("Invalid width");
                            }
                        }
                        while (!Int32.TryParse(value2, out int w1) || !(w1 > 0));
                        answer = r.SetWidth(width);
                        Console.WriteLine("New width is :" + answer);
                        break;
                    case 5:
                        answer = r.GetPerimeter();
                        Console.WriteLine("Width is :" + answer);
                        break;
                    case 6:
                        answer = r.GetArea();
                        Console.WriteLine("Width is :" + answer);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            while (!(select == 7));
        }
    }
}
