// Copyright 2005-2013 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using System;
using System.Linq;

namespace CommandLine.Core
{
    internal static class NameExtensions
    {
        public static bool MatchName(this string value, string shortName, string[] longName, StringComparer comparer)
        {
            if (value == null) throw new ArgumentNullException("value");

            return value.Length == 1
               ? comparer.Equals(value, shortName)
               : longName.Any(x =>  comparer.Equals(value, x));
        }
    }
}
