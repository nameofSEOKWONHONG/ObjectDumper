﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Diagnostics.Extensions
{
    internal static class TypeExtensions
    {
        /// <summary>
        /// Source: https://github.com/thomasgalliker/CrossPlatformLibrary/blob/0ea2e849dfccee3f68e719c19daef2eaabec190e/CrossPlatformLibrary/Extensions/TypeExtensions.cs
        /// </summary>
        internal static string GetFormattedName(this Type type)
        {
            var typeInfo = type.GetTypeInfo();
            if (!typeInfo.IsGenericType)
            {
                return type.Name;
            }

            return $"{type.Name.Substring(0, type.Name.IndexOf('`'))}<{string.Join(", ", typeInfo.GenericTypeArguments.Select(t => t.GetFormattedName()))}>";
        }
    }
}
