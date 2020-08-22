namespace AVP.CalculationEngine.Abstractions
{
    public interface IOperator
    {
        IInput A { get; }
        IInput B { get; }
        IOutput C { get; }
    }
}
