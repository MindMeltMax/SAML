﻿using Microsoft.Xna.Framework;
using Newtonsoft.Json.Linq;
using StardewValley.GameData.HomeRenovations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Utilities.Extensions
{
    public static class RectangleExtensions
    {
        public static bool Intersects(this Rectangle rect, Rectangle other, out Vector2 intersectPoint)
        {
            intersectPoint = Vector2.Zero;
            if (!rect.Intersects(other))
                return false;

            int x = Math.Max(other.X - rect.X, rect.X - other.X);
            int y = Math.Max(other.Y - rect.Y, rect.Y - other.Y);

            intersectPoint = new(x, y);
            return true;
        }
    }
}
