using SAML.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void FocusChangedEventHandler(object sender, FocusChangedEventArgs e);

    public class FocusChangedEventArgs(IFocusable? focused = null) : EventArgs
    {
        /// <summary>
        /// The value of the currently focused <see cref="IFocusable"/>
        /// </summary>
        public IFocusable? Focused { get; } = focused;
    }
}
