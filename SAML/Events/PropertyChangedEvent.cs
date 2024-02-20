using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);

    public class PropertyChangedEventArgs(string propertyName) : EventArgs
    {
        /// <summary>
        /// The name of the property who's value was changed
        /// </summary>
        public string PropertyName { get; } = propertyName;
    }
}
