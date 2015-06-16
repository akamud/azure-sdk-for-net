namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class StorageAccountCreateParameters : Resource
    {
        /// <summary>
        /// Gets or sets the account type. Possible values for this property
        /// include: 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS',
        /// 'Standard_RAGRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "accountType")]
        public AccountType? AccountType { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
