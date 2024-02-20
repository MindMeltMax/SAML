using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAML.Utilities.Extensions
{
    public static class EnumExtensions
    {
        public static bool HasThisFlag(this DecorationSides sides, DecorationSides flag) => sides.HasFlag(flag) || sides == DecorationSides.All;

        public static bool HasAllFlags(this DecorationSides sides) => sides == DecorationSides.All || ((int)sides) == 15;
    }
}
