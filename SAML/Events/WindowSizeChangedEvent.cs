using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void WindowSizeChangedEventHandler(object sender, WindowSizeChangedEventArgs e);

    public class WindowSizeChangedEventArgs(Rectangle oldBounds, Rectangle newBounds) : EventArgs
    {
        /// <summary>
        /// The old window size rectangle
        /// </summary>
        public Rectangle OldBounds { get; } = oldBounds;

        /// <summary>
        /// The new window size rectangle
        /// </summary>
        public Rectangle NewBounds { get; } = newBounds;
    }
}
