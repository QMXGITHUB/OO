using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OO
{
    public class Length
    {
        private double len;
        private LengthUnit lenUnit = LengthUnit.m;
        public Length(double length) 
        {
            this.len = length;
        }

        public Length(double length, LengthUnit lengthUnit)
        {
            this.len = length;
            this.lenUnit = lengthUnit;
        }

        public double GetLength() 
        {
            return this.len; 
        }

        public LengthUnit GetUnit()
        {
            return this.lenUnit;
        }

        public bool Equal(Length length)
        {
            if (len == length.GetLength())
            {
                if (lenUnit == length.GetUnit())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
	        {
                if (lenUnit == length.lenUnit)
                {
                    return false;
                }
                else
                {
                    if (len == length.UnifyLengthUnit(lenUnit))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
	        }
        }

        public double UnifyLengthUnit(LengthUnit lengthUnit)
        {
            if ()
            {
                
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