using System;

namespace FireBlade.AeroForms.Native {

    [Flags]
    internal enum DwmBlurBehindFlags : int {
        Enable                  = 0x00000001,
        BlurRegion              = 0x00000002,
        TransitionOnMaximized   = 0x00000004
    }

}
