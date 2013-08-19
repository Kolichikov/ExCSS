﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable CheckNamespace
namespace ExCSS
// ReSharper restore CheckNamespace
{
    public class TermList : Term
    {
        private readonly List<Term> _items;

        public TermList()
        {
            _items = new List<Term>();
            RuleValueType = RuleValueType.ValueList;
        }

        public TermList(List<Term> items)
        {
            _items = items;
            RuleValueType = RuleValueType.ValueList;
        }

        public int Length
        {
            get { return _items.Count; }
        }

        
        [IndexerName("ListItems")]
        public Term this[int index]
        {
            get { return index >= 0 && index < _items.Count ? _items[index] : null; }
        }

        public Term Item(int index)
        {
            return this[index];
        }
        
        public override string ToString()
        {
            var values = new string[_items.Count];

            for (var i = 0; i < _items.Count; i++)
            {
                values[i] = _items[i].ToString();
            }

            return string.Join(" ", values);
        }
    }
}
