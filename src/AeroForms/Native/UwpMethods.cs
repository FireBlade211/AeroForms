using System.Runtime.InteropServices;
using System.Text;

namespace FireBlade.AeroForms.Native {

    internal static class UwpMethods {

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetCurrentPackageFullName(ref int packageFullNameLength, ref StringBuilder packageFullName);

    }

}
