using AVP.CalculationEngine.Abstractions;
using AVP.CalculationEngine.DataTypes;
using System.Collections.Generic;

namespace AVP.CalculationEngine.Model.Expressions
{
    public class FunctionBlock : IExpressionDataBlock
    {
        public ExpressionBlockType Type => ExpressionBlockType.Function;
        public Dictionary<IInput, IExpressionDataBlock> Inputs { get; set; }
    }
}
