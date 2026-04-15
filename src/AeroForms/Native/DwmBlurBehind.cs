using System;
using System.Runtime.InteropServices;

namespace FireBlade.AeroForms.Native {

    [StructLayout(LayoutKind.Sequential)]
    internal struct DwmBlurBehind {
        public DwmBlurBehindFlags dwFlags;
        public bool fEnable;
        public IntPtr hRgnBlur;
        public bool fTransitionOnMaximized;
    }

}
