// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [GeneratedDllImport(Libraries.Crypt32, SetLastError = true)]
        public static unsafe partial CERT_CONTEXT* CertEnumCertificatesInStore(
            IntPtr hCertStore,
            CERT_CONTEXT* pPrevCertContext);
    }
}
