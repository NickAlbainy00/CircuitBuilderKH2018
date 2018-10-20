using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic
{
    public interface ILogicGate : ILogicNode
    /*  Logic gates take a boolean input to make a boolean output.
     * 
     */
    {
        // Returns the number of inputs for the given gate
        int GetInputSize();
        // See above for outputs.
        int GetOutputSize();
        // Returns the logical expression symbol for the given gate
        string GetSymbol();
        // Returns the logical expression as a boolean for the given node.
        bool EvaluateBoolean();
        // Sets input[index] equal to the reference of the connected item
        void SetInput(int index, ILogicGate gate);
    }
}