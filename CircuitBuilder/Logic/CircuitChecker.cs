using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic
{
    public static class CircuitChecker
    {
        // Circuit checker is used to check whether a circuit works

        /// <summary>
        /// Checks if the circuit has a valid set of connections from output to input
        /// </summary>
        /// <returns></returns>
        public static bool isValidCircuit(ILogicNode node)
        {
            // if the node is a gate, check that there are no inputs set to null 
            if (node.IsGate())
            {
               foreach(ILogicNode child in node.GetNodeInputs()){
                    // null children mean that there is a connection that goes to nothing, this is invalid

                    if(child == null)
                    {
                        return false;
                    }else if (child.IsGate())
                    {
                        isValidCircuit(child);
                    }
               }
            }

            // if not a gate, then it is an input and the connection is valid
            return true;
        }
    }
}