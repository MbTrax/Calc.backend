namespace Calc.Models
{
    public interface ICalcRepository
    {
        double Plus(Values values);
        double Minus(Values values);
        double Division(Values values);
        double Multiplication(Values values);
        double Pow(Values values);
        double Sqrt(Values values);
        double CalcFromString(Values values);
    }
}
