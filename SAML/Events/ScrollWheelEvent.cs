using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void ScrollWheelEventHandler(object sender, ScrollWheelEventArgs e);

    public class ScrollWheelEventArgs(ScrollDirection direction) : EventArgs
    {
        public ScrollDirection Direction { get; } = direction;
    }
}
