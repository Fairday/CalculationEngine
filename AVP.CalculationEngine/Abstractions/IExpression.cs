using System.Collections.Generic;

namespace AVP.CalculationEngine.Abstractions
{
    public interface IExpression : IUnit
    {
        IReadOnlyList<IExpressionDataBlock> ExpressionDataBlocks { get; }
        IOutput Output { get; }
    }
}
