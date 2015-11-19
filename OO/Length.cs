using System;

namespace OO
{
    public class Length
    {
        readonly double len;
        private double p;
        private LenghtUnit lenghtUnit;

        public Length(double len):this(len, LenghtUnit.m)
        {
        }

        public Length(double len, LenghtUnit lenghtUnit)
        {
            this.len = len;
            this.lenghtUnit = lenghtUnit;
        }

        public double Len 
        {
            get { return this.len; }
        }

        public override bool Equals(object obj)
        {
            Length length = (Length) obj;
            return Math.Abs(GetUnify() - length.GetUnify()) < 0.0001;
        }

        private double GetUnify()
        {
            return len * (double) lenghtUnit;
        }
    }

    public enum LenghtUnit
    {
        cm = 10,
        m = 1000,
        mm = 1
    }
}