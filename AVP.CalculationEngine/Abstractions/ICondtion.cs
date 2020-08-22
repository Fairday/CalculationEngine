using System.Collections.Generic;

namespace AVP.CalculationEngine.Abstractions
{
    public interface ICondtion : IUnit
    {
        IReadOnlyList<IUnit> SubroutineSequence { get; }
        IOutput Output { get; }
    }
}
