using System;
using System.Runtime.Serialization;

namespace FireBlade.AeroForms.Dwm {

    [Serializable]
    class DwmCompositionException : Exception {

        public DwmCompositionException(string m)
            : base(m) {
        }

        public DwmCompositionException(string m, Exception innerException)
            : base(m, innerException) {
        }

    }

}
