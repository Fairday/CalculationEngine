using System.Collections.Generic;

namespace AVP.CalculationEngine.Abstractions
{
    public interface IProcedure : IUnit
    {
        IReadOnlyList<IOutput> Outputs { get; }
        IReadOnlyList<IUnit> SubroutineSequence { get; }
    }
}
