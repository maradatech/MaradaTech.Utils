using System;
using System.Collections.Generic;
using System.Linq;

namespace MaradaTech.Utils.SystemExtensions.IO
{
    public static class PathExtensions
    {
        public static string MakePathFrom(char pathSeperator = '/', params string[] values)
        {
            if(values.Any(s => s is null || s == String.Empty))
                throw new ArgumentException("At least one of the provided parameters were null", nameof(values));
            if(pathSeperator != '/' && pathSeperator != '\\')
                throw new ArgumentException("Must be either '/' (default) or '\'", nameof(pathSeperator));
            string path = String.Empty;
            foreach(string item in values)
            {
                path += String.Concat(item, pathSeperator);
            }
            return path;
        }
    }
}
