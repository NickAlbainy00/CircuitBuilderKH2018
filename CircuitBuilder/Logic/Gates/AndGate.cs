using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic.Gates
{
    public class AndGate : ILogicGate
    {
        public const string NAME = "AND";
        public const string SYMBOL = "*";

        public ILogicGate[] inputs;

        public AndGate() { }
        public AndGate(int size)
        {
            inputs = new ILogicGate[size];
        }
        public AndGate(ILogicGate[] inputs)
        {
            this.inputs = inputs;
        }

        public string EvaluateString() 
        {
            string returnValue = "";

            // Loops for inputs.Length - 1 times because binary expression
            for (int index = 0; index < inputs.Length - 1; index++)
                returnValue += inputs[index].EvaluateString() + SYMBOL;

            return returnValue + inputs[inputs.Length - 1].EvaluateString();


        }
        public bool EvaluateBoolean() 
        {
            foreach (ILogicGate n in inputs)
                if (!n.EvaluateBoolean())
                    return false;

            return true;
        }

        public int GetInputSize()
        {
            return inputs.Length;
        }

        public int GetOutputSize()
        {
            return 1;
        }

        public bool IsInput()
        {
            return false;
        }

        public bool IsGate()
        {
            return true;
        }

        public string GetName()
        {
            return NAME;
        }

        public string GetSymbol()
        {
            return SYMBOL;
        }

        public void SetInput(int index, ILogicGate gate)
        {
            inputs[index] = gate;
        }
    }
}