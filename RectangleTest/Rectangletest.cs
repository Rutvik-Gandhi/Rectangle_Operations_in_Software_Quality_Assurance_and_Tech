using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG8170_W23_Midterm_DNF;

namespace PROG8170_w23_Midterm_DNF_RectangleTest

{
    public class Rectangletest
    {
        [Test]
        public void GetLength_Input001_Result001()
        {
            Rectangle rectangle = new Rectangle(1,2);
            int expected = 1;
            int actual = rectangle.GetLength();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetLength_Input002_Result002()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 1;
            int actual = rectangle.GetLength();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetLength_Input003_Result003()
        {
            Rectangle rectangle = new Rectangle(0, 0);
            int expected = 0;
            int actual = rectangle.GetLength();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void SetLength_Input001_Result001()
        {
            Rectangle rectangle = new Rectangle(0, 1);
            int expected = 0;
            int actual = rectangle.SetLength(0);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void SetLength_Input002_Result002()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 1;
            int actual = rectangle.SetLength(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void SetLength_Input003_Result003()
        {
            Rectangle rectangle = new Rectangle(2, 1);
            int expected = 2;
            int actual = rectangle.SetLength(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetWidth_Input001_Result0001()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 1;
            int actual = rectangle.GetWidth();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetWidth_Input002_Result002()
        {
            Rectangle rectangle = new Rectangle(1, 0);
            int expected = 0;
            int actual = rectangle.GetWidth();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetWidth_Input003_Result003()
        {
            Rectangle rectangle = new Rectangle(1, 2);
            int expected = 2;
            int actual = rectangle.GetWidth();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void SetWidth_Input001_Result001()
        {
            Rectangle rectangle = new Rectangle(1, 0);
            int expected = 0;
            int actual = rectangle.SetLength(0);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void SetWidth_Input002_Result002()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 1;
            int actual = rectangle.SetLength(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void SetWidth_Input003_Result003()
        {
            Rectangle rectangle = new Rectangle(1, 2);
            int expected = 2;
            int actual = rectangle.SetLength(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetPerimeter_Input001_Result001()
        {
            Rectangle rectangle = new Rectangle(0, 0);
            int expected = 0;
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetPerimeter_Input002_Result002()
        {
            Rectangle rectangle = new Rectangle(1, 0);
            int expected = 2;
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetPerimeter_Input003_Result003()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 4;
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetArea_Input001_Result001()
        {
            Rectangle rectangle = new Rectangle(0, 0);
            int expected = 0;
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetArea_Input002_Result002()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            int expected = 1;
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetArea_Input003_Result003()
        {
            Rectangle rectangle = new Rectangle(2, 2);
            int expected = 4;
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }
    }
}
