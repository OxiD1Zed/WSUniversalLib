using System;
using System.Collections.Generic;

namespace WSUniversalLib
{
    public class Calculation
    {
        private readonly List<double> _coefficients;
        private readonly List<double> _interest;

        public Calculation()
        {
            _coefficients = new List<double>() { 1.1, 2.5, 8.43 };
            _interest = new List<double>() { 0.003, 0.0012 };
        }

        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length) 
        {
            if (productType > _coefficients.Count || 
                productType < 1 || 
                materialType > _interest.Count || 
                materialType < 1 || 
                count < 0 || 
                width < 0 || 
                length < 0
                ) return -1;

            double materialsOfProduct = width * length * _coefficients[productType - 1] / (1 - _interest[materialType - 1]);
            return (int)Math.Ceiling(materialsOfProduct * count);
        }
    }
}
