using AVP.CalculationEngine.Abstractions;
using AVP.CalculationEngine.DataTypes;

namespace AVP.CalculationEngine.Model.Expressions
{
    public class OperatorBlock : IExpressionDataBlock
    {
        public ExpressionBlockType Type => ExpressionBlockType.Operator;
        public string Operator { get; set; }
    }
}
