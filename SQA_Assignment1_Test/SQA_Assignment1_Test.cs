using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQA_Assignment1;
using NUnit.Framework;

namespace SQA_Assignment1_Test
{

    [TestFixture]
    class SQA_Assignment1_Test
    {
        [Test]
        public void GetLength_input6_expectedLengthEquals6()
        {
            //set data varibale
            int len = 6;
            int wid = 4;
            Rectangle rectangleTest = new Rectangle(wid,len);

            //implement Test
            int length = rectangleTest.GetLength();

            //assert check
            Assert.AreEqual(length, len);


        }

        [Test]
        public void GetWidth_input4_expectedWidthEquals4()
        {
            //set data varibale
            int len = 6;
            int wid = 4;
            Rectangle rectangleTest = new Rectangle(wid, len);

            //implement Test
            int width = rectangleTest.GetWidth();

            //assert check
            Assert.AreEqual(width, wid);


        }

        [Test]
        public void SetWidth_input10_expectedWidthNotEquals4()
        {
            //set data varibale
            int len = 6;
            int wid = 4;
            int newWidth = 10;
            Rectangle rectangleTest = new Rectangle(wid, len);

            //implement Test
            int width = rectangleTest.SetWidth(newWidth);

            //assert check
            Assert.AreNotEqual(width,wid);


        }

        [Test]
        public void SetLength_input12_expectedLengthNotEquals6()
        {
            //set data varibale
            int len = 6;
            int wid = 4;
            int newLength = 10;
            Rectangle rectangleTest = new Rectangle(wid, len);

            //implement Test
            int length = rectangleTest.SetWidth(newLength);

            //assert check
            Assert.AreNotEqual(length, len);


        }

        [Test]
        public void GetPerimeter_inputLengthWidth_expectedPerimeter()
        {
            //set data varibale
            int len = 6;
            int wid = 4;
            int pm = 20;
            Rectangle rectangleTest = new Rectangle(wid, len);

            //implement Test
            int perimeter = rectangleTest.GetPerimeter();

            //assert check
            Assert.AreEqual(perimeter, pm);


        }

        [Test]
        public void GetArea_inputLengthWidth_expectedArea()
        {
            //set data varibale
            int len = 6;
            int wid = 4;
            int a = 24;
            Rectangle rectangleTest = new Rectangle(wid, len);

            //implement Test
            int area = rectangleTest.GetArea();

            //assert check
            Assert.AreEqual(area, a);


        }

    }
}
