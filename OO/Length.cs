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
            if (EqualForDouble(len,length.UnifyLengthUnit(lenUnit)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EqualForDouble(double data1, double data2)
        {
            return Math.Abs(data1 - data2) < 0.0000001;
        }

        public double UnifyLengthUnit(LengthUnit lengthUnit)
        {
            if (lenUnit == lengthUnit)
            {
                return this.len;
            }
            else
            {
                return this.len *  LengthUnitExchange.CalculateMutiples(lenUnit, lengthUnit);
            }
        }
    }
}