using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void ToggleEventHandler(object sender, ToggleEventArgs e);

    public class ToggleEventArgs(bool isToggled) : EventArgs
    {
        /// <summary>
        /// Whether the toggle was set to on or off
        /// </summary>
        public bool IsToggled { get; } = isToggled;
    }
}
