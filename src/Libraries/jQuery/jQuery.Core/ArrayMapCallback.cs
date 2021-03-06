// ArrayMapCallback.cs
// Script#/Libraries/jQuery/jQueryCore
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi {

    /// <summary>
    /// A callback to be invoked for each item in an array being mapped.
    /// </summary>
    /// <param name="item">The item within the array.</param>
    /// <param name="index">The index of the item.</param>
    /// <returns>The value that the item was mapped to.</returns>
    [IgnoreNamespace]
    [Imported]
    public delegate object ArrayMapCallback(object item, int index);
}
