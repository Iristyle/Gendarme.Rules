using System;
using Gendarme.Framework;
using Gendarme.Framework.Engines;

namespace Gendarme.Rules
{
    [Problem("Gendarme doods forgot to attribute rules with SuppressMessageEngine")]
    [Solution("Turn this rule on to enable it")]
    [EngineDependency(typeof(SuppressMessageEngine))]
    public class AddSuppressMessageSupportRule : Rule
    {
    }
}
