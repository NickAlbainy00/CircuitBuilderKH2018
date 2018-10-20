using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic
{
    public interface ILogicNode
    /*  LogicNodes are essentially magical functions that take a list of inputs,
     *  output a function of said inputs. Nothing too incredibly horrible.
     *  
     *  Anything that's an input should be defined as an output with no input,
     *   and a             gate  should be defined as an output with input(s).
     */
    {
        // Gets the list of all relevant inputs to the given node.
        List<ILogicNode> GetNodeInputs();

        // Determines status of being an input.
        bool IsInput();
        // Determines status of being a gate.
        bool IsGate();
        // Every element, gate or input, has its own individual name.
        //  ABSOLUTELY ABSOLUTELY, gates should have string names FORMATTED_LIKE_THIS,
        //  and variables/inputs should have string names formattedLikeThis.
        string GetName();

        // Returns the logical expression as a string for the given node.
        string Evaluate();
    }
}