﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ReleaseNotesUtil
{
    [DataContract]
    internal class RuleFileContent
    {
        [DataMember]
#pragma warning disable CA1002 // Do not expose generic lists
        public List<RuleInfo> Rules { get; set; } = new List<RuleInfo>();
#pragma warning restore CA1002 // Do not expose generic lists
    }
}
