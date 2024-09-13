// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;


namespace Garnet.server
{
    class LuaSimpleString
    {
        public string Contents { get; }

        public LuaSimpleString(string contents) => Contents = contents;

        public string ToString()
        {
            return Contents;
        }
    }
}