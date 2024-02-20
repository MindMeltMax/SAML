using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void TextChangeEventHandler(object sender, TextChangeEventArgs e);

    public class TextChangeEventArgs(char c) : EventArgs
    {
        public char Char { get; } = c;

        public string Text => $"{Char}";

        public int Num => char.IsNumber(Char) ? int.Parse(Text) : -1;
    }
}
