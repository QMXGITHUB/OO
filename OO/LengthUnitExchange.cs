using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OO
{
    public class LengthUnitExchange
    {
        static double UnitMtoM = 1;
        static double UnitMtoCM = 100;
        static double UnitMtoMM =1000;

        static double UnitCMtoM = 0.01;
        static double UnitCMtoCM = 1;
        static double UnitCMtoMM = 0.1;

        static double UnitMMtoM = 0.001;
        static double UnitMMtoCM = 0.1;
        static double UnitMMtoMM = 1;
        public static double CalculateMutiples(LengthUnit originUnit, LengthUnit destUnit)
        {
            switch (originUnit)
            {
                case LengthUnit.m:
                    return CalculateMutiplesForM(destUnit);
                case LengthUnit.cm:
                    return CalculateMutiplesForCM(destUnit);
                case LengthUnit.mm:
                    return CalculateMutiplesForMM(destUnit);
                default:
                    return 1;
            }
            
        }

        private static double CalculateMutiplesForMM(LengthUnit destUnit)
        {
            switch (destUnit)
            {
                case LengthUnit.m:
                    return UnitMMtoM;
                case LengthUnit.cm:
                    return UnitMMtoCM;
                case LengthUnit.mm:
                    return UnitMMtoMM;
                default:
                    throw new Exception("There is no defination about destUnit.");
            }
        }

        private static double CalculateMutiplesForCM(LengthUnit destUnit)
        {
            switch (destUnit)
            {
                case LengthUnit.m:
                    return UnitCMtoM;
                case LengthUnit.cm:
                    return UnitCMtoCM;
                case LengthUnit.mm:
                    return UnitCMtoMM;
                default:
                    throw new Exception("There is no defination about destUnit.");
            }
        }

        static double CalculateMutiplesForM(LengthUnit destUnit)
        {
            switch (destUnit)
            {
                case LengthUnit.m:
                    return UnitMtoM;
                case LengthUnit.cm:
                    return UnitMtoCM;
                case LengthUnit.mm:
                    return UnitMtoMM;
                default:
                    throw new Exception("There is no defination about destUnit.");
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