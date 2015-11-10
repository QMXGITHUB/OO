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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
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
                    throw new Exception("There is no defination about same length with diferent unit!!!");
                }
            }
            else
	        {
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