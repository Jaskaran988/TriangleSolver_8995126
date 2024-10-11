using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTests
    {
        // 1. Valid Equilateral Triangle
        [Test]
        public void ValidTriangle_Input13and13and13_OutputEquilateralTriangle()
        {
            int side1 = 13;
            int side2 = 13;
            int side3 = 13;
            string expected = "Equilateral triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(result, Is.EqualTo(expected));
        }
        // 2. Valid Isosceles Triangle (case 1)
        [Test]
        public void ValidTriangle_Input12and12and4_OutputIsoscelesTriangle_Case1()
        {
            int side1 = 12;
            int side2 = 12;
            int side3 = 4;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 3. Valid Isosceles Triangle (case 2)
        [Test]
        public void ValidTriangle_Input13and13and6_OutputIsoscelesTriangle_Case2()
        {
            int side1 = 13;
            int side2 = 13;
            int side3 = 6;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 4. Valid Isosceles Triangle (case 3)
        [Test]
        public void ValidTriangle_Input16and16and13_OutputIsoscelesTriangle_Case3()
        {
            int side1 = 16;
            int side2 = 16;
            int side3 = 13;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }
        // 5. Valid Scalene Triangle (case 1)
        [Test]
        public void ValidTriangle_Input14and13and18_OutputScaleneTriangle_Case1()
        {
            int side1 = 14;
            int side2 = 13;
            int side3 = 18;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 6. Valid Scalene Triangle (case 2)
        [Test]
        public void ValidTriangle_Input30and28and23_OutputScaleneTriangle_Case2()
        {
            int side1 = 30;
            int side2 = 28;
            int side3 = 23;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 7. Valid Scalene Triangle (case 3)
        [Test]
        public void ValidTriangle_Input23and32and21_OutputScaleneTriangle_Case3()
        {
            int side1 = 23;
            int side2 = 32;
            int side3 = 21;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 8. Valid Scalene Triangle (case 4)
        [Test]
        public void ValidTriangle_Input45and39and35_OutputScaleneTriangle_Case4()
        {
            int side1 = 45;
            int side2 = 39;
            int side3 = 35;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 9. Valid Scalene Triangle (case 5)
        [Test]
        public void ValidTriangle_Input32and23and44_OutputScaleneTriangle_Case5()
        {
            int side1 = 32;
            int side2 = 23;
            int side3 = 44;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 10. Zero Length for Side1
        [Test]
        public void InvalidTriangle_Input0and13and13_OutputInvalidTriangle_ZeroLengthSide1()
        {
            int side1 = 0;
            int side2 = 13;
            int side3 = 13;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 11. Zero Length for Side2
        [Test]
        public void InvalidTriangle_Input19and0and19_OutputInvalidTriangle_ZeroLengthSide2()
        {
            int side1 = 19;
            int side2 = 0;
            int side3 = 19;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 12. Zero Length for Side3
        [Test]
        public void InvalidTriangle_Input34and34and0_OutputInvalidTriangle_ZeroLengthSide3()
        {
            int side1 = 34;
            int side2 = 34;
            int side3 = 0;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 13. Invalid Triangle - Sum of two sides not greater than the third
        [Test]
        public void InvalidTriangle_Input15and15and32_OutputInvalidTriangle_SumOfSides()
        {
            int side1 = 15;
            int side2 = 15;
            int side3 = 32;
            string expected = "INVALID!!";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 14. Invalid Triangle - Negative side
        [Test]
        public void InvalidTriangle_InputNeg13and6and7_OutputInvalidTriangle_NegativeSide()
        {
            int side1 = -13;
            int side2 = 6;
            int side3 = 7;
            string expected = "INVALID!!";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 15. Invalid Triangle - All sides zero
        [Test]
        public void InvalidTriangle_Input0and0and0_OutputInvalidTriangle_AllSidesZero()
        {
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
