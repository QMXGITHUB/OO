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
        public void Varify_two_same_lengths_with_default_unit_m()
        {
            Length length1 = new Length(1);
            Length length2 = new Length(1);
            bool isTrue = length1.Equal(length2);
            Assert.True(isTrue);
        }

        [Fact]
        public void Varify_two_different_lengths_with_default_unit_m()
        {
            Length length1 = new Length(1);
            Length length2 = new Length(2);
            bool idFalse = length1.Equal(length2);
            Assert.False(idFalse);
        }

        [Fact]
        public void Varify_two_same_lengths_with_same_unit_cm()
        {
            Length length1 = new Length(1, LengthUnit.cm);
            Length length2 = new Length(1, LengthUnit.cm);
            bool isTrue = length1.Equal(length2);
            Assert.True(isTrue);
        }

        [Fact]
        public void Verify_two_different_lengths_with_same_unit_mm()
        {
            Length length1 = new Length(1, LengthUnit.mm);
            Length length2 = new Length(2, LengthUnit.mm);
            bool isFalse = length1.Equal(length2);
            Assert.False(isFalse);
        }


    }
}