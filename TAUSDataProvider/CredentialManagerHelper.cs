//===========================================================================
//  Microsoft Public License (MS-PL) 
//  http://opensource.org/licenses/ms-pl.html
//
//  This license governs use of the accompanying software. If you use the 
//  software, you accept this license. If you do not accept the license, do 
//  not use the software.
//
//  See the Readme.txt file for build and deployment instructions.
//
//  Version   Date        History
//  1.0.0.0   2014-02-24  Creation of the TAUS based sample provider
//===========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Sample.Multilingual.Provider
{
    /// <summary>
    /// Helper class for access data in the Credential Manager.  
    /// </summary>
    /// <remarks>
    /// See: http://windows.microsoft.com/en-US/Windows7/What-is-Credential-Manager?woldogcb=0
    /// </remarks>
    internal class CredentialManagerHelper
    {
        [DllImport("Advapi32.dll", EntryPoint = "CredReadW", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool CredRead(string target, CRED_TYPE type, uint reservedFlag, out IntPtr CredentialPtr);
        [DllImport("Advapi32.dll", EntryPoint = "CredFree", SetLastError = true)]
        static extern bool CredFree([In] IntPtr cred);

        /// <summary>
        /// Read the user name and password from the Windows Credential Manager
        /// </summary>
        /// <param name="targetName">name of the credential to read</param>
        /// <param name="credType">Type of the credential to read</param>
        /// <param name="flags">Currently reserved and must be zero</param>
        /// <param name="userName">Stored user name</param>
        /// <param name="password">Store password</param>
        /// <returns></returns>
        public static Boolean ReadCredentials(String targetName, CRED_TYPE credType, uint flags, out String userName, out SecureString password)
        {
            userName = null;
            password = null;

            IntPtr pCredentials = IntPtr.Zero;
            //  See: http://msdn.microsoft.com/en-us/library/windows/desktop/aa374804(v=vs.85).aspx
            Boolean result = CredRead(targetName, credType, flags, out pCredentials);
            if (result == true)
            {
                Credential cred = (Credential)Marshal.PtrToStructure(pCredentials, typeof(Credential));

                userName = cred.UserName;
                password = new SecureString();
                foreach (char passChar in cred.CredentialBlob)
                {
                    password.AppendChar(passChar);
                }
                password.MakeReadOnly();

                //  See: http://msdn.microsoft.com/en-us/library/windows/desktop/aa374796(v=vs.85).aspx
                CredFree(pCredentials);
            }
            return result;
        }
    }

    /// <summary>
    /// Derived from _CREDENTIALW in %ProgramFiles(x86)%\Windows Kits\8.0\Include\um\wincred.h
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct Credential
    {
        public UInt32 Flags;
        public CRED_TYPE Type;
        public string TargetName;
        public string Comment;
        public System.Runtime.InteropServices.ComTypes.FILETIME LastWritten;
        public UInt32 CredentialBlobSize;
        public string CredentialBlob;
        public CRED_PERSIST Persist;
        public UInt32 AttributeCount;
        public IntPtr Attributes;
        public string TargetAlias;
        public string UserName;
    }

    /// <summary>
    /// Values from CRED_TYPE_* enum in %ProgramFiles(x86)%\Windows Kits\8.0\Include\um\wincred.h
    /// </summary>
    internal enum CRED_TYPE : uint
    {
        GENERIC = 1,
        DOMAIN_PASSWORD = 2,
        DOMAIN_CERTIFICATE = 3,
        DOMAIN_VISIBLE_PASSWORD = 4,
        GENERIC_CERTIFICATE = 5,
        DOMAIN_EXTENDED = 6,
        MAXIMUM = 7,                    // Maximum supported cred type
        MAXIMUM_EX = (MAXIMUM + 1000)   // Allow new applications to run on old OSes
    }

    /// <summary>
    /// Values from CRED_PERSIST_* in %ProgramFiles(x86)%\Windows Kits\8.0\Include\um\wincred.h
    /// </summary>
    internal enum CRED_PERSIST : uint
    {
        NONE = 0,
        SESSION = 1,
        LOCAL_MACHINE = 2,
        ENTERPRISE = 3
    }
}
