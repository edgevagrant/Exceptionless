﻿#region Copyright 2014 Exceptionless

// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU Affero General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
//     http://www.gnu.org/licenses/agpl-3.0.html

#endregion

using System;
using System.Collections.Generic;

namespace Exceptionless.Models {
    public class DataDictionary : Dictionary<string, object> {
        public const string EXCEPTION_INFO_KEY = "__ExceptionInfo";
        public const string TRACE_LOG_KEY = "TraceLog";

        public DataDictionary() : base(StringComparer.OrdinalIgnoreCase) {}

        public object GetValueOrDefault(string key) {
            object value;
            return TryGetValue(key, out value) ? value : null;
        }

        public object GetValueOrDefault(string key, object defaultValue) {
            object value;
            return TryGetValue(key, out value) ? value : defaultValue;
        }

        public object GetValueOrDefault(string key, Func<object> defaultValueProvider) {
            object value;
            return TryGetValue(key, out value) ? value : defaultValueProvider();
        }
    }
}