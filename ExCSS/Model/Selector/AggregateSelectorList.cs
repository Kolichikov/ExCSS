﻿using System.Text;

// ReSharper disable CheckNamespace
namespace ExCSS
// ReSharper restore CheckNamespace
{
    public class AggregateSelectorList : SelectorList
    {
        internal static AggregateSelectorList Create(params SimpleSelector[] selectors)
        {
            var compound = new AggregateSelectorList();

            foreach (var t in selectors)
            {
                compound.Selectors.Add(t);
            }

            return compound;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var selector in Selectors)
            {
                builder.Append(selector);
            }

            return builder.ToString();
        }
    }
}
