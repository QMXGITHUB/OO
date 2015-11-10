using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Xunit;

namespace OO
{
    public class test_1
    {
        private string same_length = "same length";
        private String different_length = "different_length";

        [Fact]
        public void Given_2_same_lengths_return_same_length()
        {
            double length1 = 1;
            double length2 = 1;
            string actual_result = Compare_Two_Lengths(length1, length2,"m","m");
            Assert.Equal("same length",actual_result);
        }

        [Fact]
        public void Given_2_different_lengths_return_different_length()
        {
            double length1 = 1;
            double length2 = 2;
            string actual_result = Compare_Two_Lengths(length1, length2,"m","m");
            Assert.Equal("different length", actual_result);
        }

        [Fact]
        public void Given_2_same_lengths_with_same_unit_m_return_same_length()
        {
            double length1 = 1;
            string unit1 = "m";
            double length2 = 1;
            string unit2 = "m";
            string actual_result = Compare_Two_Lengths(length1, length2,unit1,unit2);
            Assert.Equal("same length",actual_result);
        }
        [Fact]
        public void Given_2_different_lengths_with_same_unit_mm_return_same_length()
        {
            double length1 = 1;
            string unit1 = "mm";
            double length2 = 2;
            string unit2 = "mm";
            string actual_result = Compare_Two_Lengths(length1, length2, unit1, unit2);
            Assert.Equal("different length", actual_result);
        }

        private string Compare_Two_Lengths(double length1, double length2,string unit1,string unit2)
        {
            if(length1==length2)
                 return "same length";
            else
            {
                return "different length";
            }
        }
    }
}