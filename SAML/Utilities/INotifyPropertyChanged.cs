using SAML.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Utilities
{
    public interface INotifyPropertyChanged
    {
        /// <summary>
        /// An event which fires when the value of a property has changed
        /// </summary>
        event PropertyChangedEventHandler? PropertyChanged;
    }
}
