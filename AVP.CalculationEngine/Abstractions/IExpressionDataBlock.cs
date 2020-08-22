using AVP.CalculationEngine.DataTypes;

namespace AVP.CalculationEngine.Abstractions
{
    public interface IExpressionDataBlock
    {
        ExpressionBlockType Type { get; }
    }
}
