using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class ListItem
    {
        public string Name;
        public int Value;
        public ListItem(string name, int value)
        {
            Name = name; Value = value;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Name;
        }
    }
