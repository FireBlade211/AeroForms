using System;

namespace FireBlade.AeroForms.Native {

    [Flags]
    internal enum DwmThumbnailFlags {
        RectDestination = 0x1,
        RectSource = 0x2,
        Opacity = 0x4,
        Visible = 0x8,
        SourceClientAreaOnly = 0x10
    }

}
