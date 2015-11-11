using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OO
{
    public class Length
    {
        private double len;
        private LengthUnit lengthUnit = LengthUnit.m;
        public Length(double length) 
        {
            this.len = length;
        }

        public Length(double length, LengthUnit lengthUnit)
        {
            this.len = length;
            this.lengthUnit = lengthUnit;
        }

        public double GetLength() 
        {
            return this.len; 
        }

        public LengthUnit GetUnit()
        {
            return this.lengthUnit;
        }

        public bool Equal(Length length)
        {
            if (len == length.GetLength())
            {
                if (lengthUnit == length.GetUnit())
                {
                    return true;
                }
                else
                {
                    //throw new Exception("We will add function for same length with diferent unit! Sorry!");
                    return false;
                }
            }
            else
	        {
                if (lengthUnit == length.lengthUnit)
                {
                    return false;
                }
                else
                {

                }
                return false;
	        }
        }



    }

    public enum LengthUnit
    {
        m,
        cm,
        mm
    }
}