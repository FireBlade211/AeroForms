using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBlade.AeroForms {

    /// <summary>
    /// Represents a virtual desktop instance.
    /// </summary>
    public struct VirtualDesktop : IEquatable<VirtualDesktop> {

        internal VirtualDesktop(Guid id) {
            Id = id;
        }

        /// <summary>
        /// Gets the virtual desktop's ID.
        /// </summary>
        public Guid Id { get; }

        public override bool Equals(object obj) {
            if (obj is VirtualDesktop)
                return Equals(obj);

            return false;
        }

        public bool Equals(VirtualDesktop other) {
            return Id == other.Id;
        }

        public override int GetHashCode() {
            return Id.GetHashCode();
        }

    }

}
