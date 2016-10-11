﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace NuGet.Commands
{
    public class MSBuildRestoreImportGroup
    {
        /// <summary>
        /// Optional position arguement used when ordering groups in the output file.
        /// </summary>
        public int Position { get; set; } = 1;

        /// <summary>
        /// Conditions applied to the item group. These will be AND'd together.
        /// </summary>
        public IList<string> Conditions { get; set; } = new List<string>();

        /// <summary>
        /// Project paths to import.
        /// </summary>
        public IList<string> Imports { get; set; } = new List<string>();

        /// <summary>
        /// Combined conditions
        /// </summary>
        public string Condition
        {
            get
            {
                return " " + string.Join(" AND ", Conditions.Select(s => s.Trim())) + " ";
            }
        }
    }
}