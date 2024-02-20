using SAML.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Utilities
{
    public interface IFocusable : IElement
    {
        /// <summary>
        /// An event which fires when the current <see cref="IFocusable"/> obtains focus
        /// </summary>
        event FocusChangedEventHandler? GotFocus;

        /// <summary>
        /// An event which fires when the current <see cref="IFocusable"/> loses focus
        /// </summary>
        event FocusChangedEventHandler? LostFocus;

        /// <summary>
        /// Assign focus to the current <see cref="IFocusable"/>
        /// </summary>
        void Focus();

        /// <summary>
        /// Remove focus from the current <see cref="IFocusable"/>
        /// </summary>
        void UnFocus();
    }
}
