//Copyright (c) Microsoft Corporation.  All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("Microsoft.WindowsAPICodePack.Shell,PublicKey=" + NationalInstrumentsPublicKey.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.WindowsAPICodePack.Sensors,PublicKey=" + NationalInstrumentsPublicKey.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.WindowsAPICodePack.ShellExtensions,PublicKey=" + NationalInstrumentsPublicKey.PublicKey)]

// Setting ComVisible to false makes the types in this assembly not visible to COM components. If you need to access a type in this assembly
// from COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ac9740bc-3035-43ee-9a68-1dde36ab1f5e")]

internal static class NationalInstrumentsPublicKey
{
    internal const string PublicKey =
        "0024000004800000940000000602000000240000525341310004000001000100f7ebf7eb647b3a" +
        "bd033740b42a4c7c408b6d70c69a1483b366caefea591d1a5ab9587a2af4cf696b9afc51044dde" +
        "fb85bc45855e036921c45876afc294c95a938db61ae09554a3016e1df76108259fb70c70b261b5" +
        "5f928d44219a38a2501f222af013d1e12a186770e2d89cc3573f84b5ca92f7f47fd34380a66e74" +
        "17aa7fed";
}
