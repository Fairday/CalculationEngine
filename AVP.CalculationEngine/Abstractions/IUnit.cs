using System.Collections.Generic;

namespace AVP.CalculationEngine.Abstractions
{
    public interface IUnit
    {
        IReadOnlyList<IInput> Inputs { get; }
    }
}
