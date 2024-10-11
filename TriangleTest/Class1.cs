using System;
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
        // Valid Equilateral Triangle
        [Test]
        public void AnalyzeTriangle_EquilateralTriangle_ShouldReturnEquilateral() { 
        
            int side1 = 13;
            int side2 = 13;
            int side3 = 13;
            string expected = "Equilateral triangle";

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
    }
