using AVP.CalculationEngine.Abstractions;
using AVP.CalculationEngine.DataTypes;

namespace AVP.CalculationEngine.Model.Expressions
{
    public class BraceBlock : IExpressionDataBlock
    {
        public ExpressionBlockType Type => ExpressionBlockType.Brace;
        public BraceType BraceType { get; set; }
    }
}
