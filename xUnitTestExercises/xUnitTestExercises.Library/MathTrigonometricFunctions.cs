using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class MathTrigonometricFunctions
    {
        // Acos - Returnează unghiul al cărui cosinus este numărul specificat.
        public double AcosMethod(double value)
        {
            return Math.Acos(value);    
        }

        // Acosh(Double) - Returnează unghiul al cărui cosinus hiperbolic este numărul specificat.
        public double AcoshMethod(float value)
        {
            return Math.Acosh(value);
        }

        // Asin - Returnează unghiul al cărui sinus este numărul specificat.
        public double AsinMethod(double value)
        {
            return Math.Asin(value);
        }

        // Asinh - Returnează unghiul al cărui sinus hiperbolic este numărul specificat.
        public double AsinhMethod(double value)
        {
            return Math.Asinh(value);
        }

        // Atan - Returnează unghiul a cărui tangentă este numărul specificat.
        public double AtanMethod(double value)
        {
            return Math.Atan(value);
        }

        // Atan2 - Returnează unghiul a cărui tangentă este câtul a două numere specificate.
        public double Atan2Method(double x, double y)
        {
            return Math.Atan2(x,y);
        }

        // Atanh - Returnează unghiul a cărui tangentă hiperbolică este numărul specificat.
        public double AtanhMethod(double value)
        {
            return Math.Atanh(value);
        }

        // Cos - Returnează cosinusul unghiului specificat.
        public double CosMethod(double value)
        {
            return Math.Cos(value);
        }

        // Cosh - Returnează cosinusul hiperbolic al unghiului specificat.
        public double CoshMethod(double vaue)
        {
            return Math.Cosh(vaue);
        }

        // Sin - Returnează sinusul unghiului specificat.
        public double SinMethod(double value)
        {
            return Math.Sin(value);
        }
                
        // Sinh - Returnează sinusul hiperbolic al unghiului specificat.
        public double SinhMethod(double value)
        {
            return Math.Sinh(value);
        }

        // Tan - Returnează tangenta unghiului specificat.
        public double TanMethod(double value)
        {
            return Math.Tan(value);
        }

        // Tanh - Returns the hyperbolic tangent of the specified angle.
        public double TanhMethod(double value)
        {
            return Math.Tanh(value);
        }

    }
}
