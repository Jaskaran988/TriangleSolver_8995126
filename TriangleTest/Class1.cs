﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using System;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTests
    {
        // 1.Valid Equilateral Triangle
        [Test]
        public void AnalyzeTriangle_EquilateralTriangle_ShouldReturnEquilateral() { 
        
            int side1 = 13;
            int side2 = 13;
            int side3 = 13;
            string expected = "Equilateral triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(result, Is.EqualTo(expected));
        }
        // 2. Valid Isosceles Triangle (case 1)
        [Test]
        public void AnalyzeTriangle_Isosceles_ShouldReturnIsosceles_Case1()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 3;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 3. Valid Isosceles Triangle (case 2)
        [Test]
        public void AnalyzeTriangle_Isosceles_ShouldReturnIsosceles_Case2()
        {
            int side1 = 6;
            int side2 = 6;
            int side3 = 4;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 4. Valid Isosceles Triangle (case 3)
        [Test]
        public void AnalyzeTriangle_Isosceles_ShouldReturnIsosceles_Case3()
        {
            int side1 = 10;
            int side2 = 10;
            int side3 = 7;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }
        // 5. Valid Scalene Triangle (case 1)
        [Test]
        public void AnalyzeTriangle_Scalene_ShouldReturnScalene_Case1()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 6. Valid Scalene Triangle (case 2)
        [Test]
        public void AnalyzeTriangle_Scalene_ShouldReturnScalene_Case2()
        {
            int side1 = 7;
            int side2 = 8;
            int side3 = 5;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 7. Valid Scalene Triangle (case 3)
        [Test]
        public void AnalyzeTriangle_Scalene_ShouldReturnScalene_Case3()
        {
            int side1 = 9;
            int side2 = 12;
            int side3 = 15;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 8. Valid Scalene Triangle (case 4)
        [Test]
        public void AnalyzeTriangle_Scalene_ShouldReturnScalene_Case4()
        {
            int side1 = 10;
            int side2 = 11;
            int side3 = 12;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 9. Valid Scalene Triangle (case 5)
        [Test]
        public void AnalyzeTriangle_Scalene_ShouldReturnScalene_Case5()
        {
            int side1 = 13;
            int side2 = 14;
            int side3 = 15;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
    }
