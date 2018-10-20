using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic.Gates
{
    public class NotGate : ILogicGate
    {
        public const string NAME = "NOT";
        public const string SYMBOL = "!";

        public ILogicGate input;

        public NotGate() { }
        public NotGate(ILogicGate input)
        {
            this.input = input
        }

        public string EvaluateString()
        {
            return String.Format("%s(%s)", SYMBOL, input.EvaluateString());


        }
        public bool EvaluateBoolean()
        {
            return input.EvaluateBoolean();
        }

        public int GetInputSize()
        {
            return 1;
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
            input = gate;
        }
    }
}