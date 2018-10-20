using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic
{
    public interface ILogicGate
    {
        // Returns the number of inputs for the given gate
        int GetInputSize();
        // See above for outputs.
        int GetOutputSize();
        // Returns the logical expression as a boolean for the given node.
        string Evaluate();
    }
}