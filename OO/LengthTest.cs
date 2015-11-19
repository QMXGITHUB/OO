using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Xunit;

namespace OO
{
    public class LengthTest
    {
        [Fact]
        public void verify_two_length_2_and_3_with_default_m()
        {
            var lenghtShort = new Length(2);
            var lenghtLong = new Length(3);

            Assert.False(lenghtShort.Equals(lenghtLong));
        }

        [Fact]
        public void verify_two_lengh_2_01_and_2_01_with_default_unit_m()
        {
            var lenghtShort = new Length(2.01);
            var lenghtLong = new Length(2.01);

            Assert.True(lenghtShort.Equals(lenghtLong));
        }

        [Fact]
        public void verify_two_lengh_2_01_and_2_01_with_unit_cm()
        {
            var lenghtShort = new Length(2.01, LenghtUnit.cm);
            var lenghtLong = new Length(2.01, LenghtUnit.cm);

            Assert.True(lenghtShort.Equals(lenghtLong));
        }

        [Fact]
        public void verify_two_lengh_2_01_and_2_01_with_unit_mm()
        {
            var lenghtShort = new Length(2.01, LenghtUnit.mm);
            var lenghtLong = new Length(2.01, LenghtUnit.mm);

            Assert.True(lenghtShort.Equals(lenghtLong));
        }
        
        [Fact]
        public void verify_two_lengh_2_01_m_and_201_cm()
        {
            var lenghtShort = new Length(2.01, LenghtUnit.m);
            var lenghtLong = new Length(201, LenghtUnit.cm);

            Assert.True(lenghtShort.Equals(lenghtLong));
        }

        [Fact]
        public void verify_two_lengh_2_001_mm_and_2001_m()
        {
            var lenghtShort = new Length(2.001, LenghtUnit.m);
            var lenghtLong = new Length(2001, LenghtUnit.mm);

            Assert.True(lenghtShort.Equals(lenghtLong));
        }

        [Fact]
        public void verify_two_lengh_0_mm_and_0_m()
        {
            var lenghtShort = new Length(2.001, LenghtUnit.m);
            var lenghtLong = new Length(2001, LenghtUnit.mm);

            Assert.True(lenghtShort.Equals(lenghtLong));
        }
    }
}