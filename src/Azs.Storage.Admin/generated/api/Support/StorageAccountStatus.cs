// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support
{

    /// <summary>The state of storage account in WAC.</summary>
    public partial struct StorageAccountStatus :
        System.IEquatable<StorageAccountStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus Active = @"Active";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus Deleted = @"Deleted";

        /// <summary>the value for an instance of the <see cref="StorageAccountStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to StorageAccountStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="StorageAccountStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new StorageAccountStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type StorageAccountStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type StorageAccountStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is StorageAccountStatus && Equals((StorageAccountStatus)obj);
        }

        /// <summary>Returns hashCode for enum StorageAccountStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="StorageAccountStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private StorageAccountStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for StorageAccountStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to StorageAccountStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="StorageAccountStatus" />.</param>

        public static implicit operator StorageAccountStatus(string value)
        {
            return new StorageAccountStatus(value);
        }

        /// <summary>Implicit operator to convert StorageAccountStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="StorageAccountStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum StorageAccountStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus e1, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum StorageAccountStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus e1, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}