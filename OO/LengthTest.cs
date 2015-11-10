using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Xunit;

namespace OO
{
    public class LenghtTest
    {
        [Fact]
        public void Given_2_same_lengths_return_same_length()
        {
            Length length1 = new Length(1);
            Length length2 = new Length(1);
            bool actual_result = length1.Equal(length2);
            Assert.True(actual_result);
        }

        [Fact]
        public void Given_2_different_lengths_return_different_length()
        {
            Length length1 = new Length(1);
            Length length2 = new Length(2);
            bool actual_result = length1.Equal(length2);
            Assert.False(actual_result);
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

        private string Compare_Two_Lengths(double length1, double length2, string unit1, string unit2)
        {
            throw new NotImplementedException();
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


    }
}