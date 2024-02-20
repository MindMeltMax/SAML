using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void SelectionChangedEventHandler(object sender, SelectionChangedEventArgs e);

    public class SelectionChangedEventArgs(object? oldValue, object? newValue) : EventArgs
    {
        public object? OldValue { get; } = oldValue;

        public object? NewValue { get; } = newValue;
    }
}
