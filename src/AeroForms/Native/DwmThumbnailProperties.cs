using System;
using System.Runtime.InteropServices;

namespace FireBlade.AeroForms.Native {

    internal struct DwmThumbnailProperties {
        public DwmThumbnailFlags dwFlags;
        public Rect rcDestination;
        public Rect rcSource;
        public byte opacity;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fVisible;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fSourceClientAreaOnly;
    }

}
