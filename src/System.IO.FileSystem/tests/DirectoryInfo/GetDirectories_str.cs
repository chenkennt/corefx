// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using Xunit;

namespace System.IO.FileSystem.Tests
{
    public class DirectoryInfo_GetDirectories_str : Directory_GetDirectories_str_str
    {
        #region Utilities

        public override string[] GetEntries(string path)
        {
            return ((new DirectoryInfo(path).GetDirectories("*").Select(x => x.FullName)).ToArray());
        }

        public override string[] GetEntries(string path, string searchPattern)
        {
            return ((new DirectoryInfo(path).GetDirectories(searchPattern).Select(x => x.FullName)).ToArray());
        }

        #endregion
    }
}
