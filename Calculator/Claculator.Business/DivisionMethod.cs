namespace Calculator.Business
{
    public class DivisionMethod
    {
        public double Division(double x, double y)
        {
            double result = x / y;
            if (y != 0)
            {
                return result;
            }
            else
            {
                // Custom business logic for divide by zero
                return 0;
            }
        }
    }
}
