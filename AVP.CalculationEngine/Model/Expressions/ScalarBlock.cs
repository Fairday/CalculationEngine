using AVP.CalculationEngine.Abstractions;
using AVP.CalculationEngine.DataTypes;

namespace AVP.CalculationEngine.Model.Expressions
{
    public class ScalarBlock : IExpressionDataBlock
    {
        public ExpressionBlockType Type => ExpressionBlockType.Scalar;
        public string Scalar { get; set; }
    }
}
