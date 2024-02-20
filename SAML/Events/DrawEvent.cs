using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Events
{
    public delegate void DrawEventHandler(object sender, DrawEventArgs e);

    public class DrawEventArgs(SpriteBatch batch) : EventArgs
    {
        /// <summary>
        /// Framework helper class to draw text and sprites to the screen
        /// </summary>
        public SpriteBatch Batch { get; } = batch;
    }
}
