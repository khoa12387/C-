using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{


    public interface ITaxCalculator
    {
        double CalculateTax(double income);
    }

    public class USATaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double income)
        {
            return income * 0.3;
        }
    }

    public class UKTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double income)
        {
            return income * 0.25;
        }
    }

    public class IndiaTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double income)
        {
            return income * 0.2;
        }
    }

    public class TaxCalculator
    {
        public double CalculateTax(ITaxCalculator taxCalculator, double income)
        {
            return taxCalculator.CalculateTax(income);
        }
    }





}
