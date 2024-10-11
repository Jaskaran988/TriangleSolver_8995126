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

    }
}
