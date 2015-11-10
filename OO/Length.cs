using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OO
{
    public class Length
    {
        double len;
        public Length(double length) 
        {
            this.len = length;
        }

        public double GetLength() 
        {
            return this.len; 
        }

        public bool Equal(Length length)
        {
           return len == length.GetLength();
        }



    }
}