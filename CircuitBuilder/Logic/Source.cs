using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CircuitBuilder.Logic
{
    public class Source : ILogicNode
    {
        // The use of a dictionary forces the lack of redundant variable definition.
        public static Dictionary<string, bool> truthValues = new Dictionary<string, bool>();
        public string name = "x";

        public Source(string name)
            // Sets name to false by default in the truthValues dictionary. 
        {
            if (name.Length > 0)
                this.name = name;

            if (!truthValues.ContainsKey(name))
                SetVariable(name, false);
        }

        public bool EvaluateBoolean()
        {
            return truthValues[name];
        }

        public string EvaluateString()
        {
            return name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public bool IsGate()
        {
            return false;
        }

        public bool IsInput()
        {
            return true;
        }

        public static void SetVariable(string varName, bool value)
        {
            truthValues.Add(varName, value);
        }

        public void SetInputState(bool value)
        {
            truthValues[this.name] = value;
        }

    }
}