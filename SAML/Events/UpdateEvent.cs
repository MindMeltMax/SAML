using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void UpdateEventHandler(object sender, UpdateEventArgs e);

    public class UpdateEventArgs(GameTime time) : EventArgs
    {
        /// <summary>
        /// The <see cref="GameTime"/> when the event was fired
        /// </summary>
        public GameTime Time { get; } = time;
    }
}
