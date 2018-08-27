﻿#region System namespaces
using System;
using System.Collections.Generic;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class AdvancedFormulas : IAdvancedFormulas
    {
        public double[] QuadraticEquation(double a, double b, double c)
        {
            // TODO - 5 - Calculate real results for the quadratic equation
            double[] answers = new double[2];
            answers[0] = ((-b + Math.Sqrt((Math.Pow(b,2)) - (4.0 * a * c)))) / (2 * a);
            answers[1] = ((-b - Math.Sqrt(Math.Pow(b,2) - (4.0 * a * c)))) / (2 * a);
            return answers;
        }
    }
}
