using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void CollectionChangedEventHandler(object sender, CollectionChangedEventArgs e);

    public class CollectionChangedEventArgs(IEnumerable? added = null, IEnumerable? removed = null) : EventArgs
    {
        public IEnumerable? Added { get; } = added;

        public IEnumerable? Removed { get; } = removed;
    }
}
