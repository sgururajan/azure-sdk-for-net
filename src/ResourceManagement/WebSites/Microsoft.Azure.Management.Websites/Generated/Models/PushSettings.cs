// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Push settings for the App.
    /// </summary>
    public partial class PushSettings
    {
        /// <summary>
        /// Initializes a new instance of the PushSettings class.
        /// </summary>
        public PushSettings() { }

        /// <summary>
        /// Initializes a new instance of the PushSettings class.
        /// </summary>
        /// <param name="isPushEnabled">Gets or sets a flag indicating whether
        /// the Push endpoint is enabled.</param>
        /// <param name="tagWhitelistJson">Gets or sets a JSON string
        /// containing a list of tags that are whitelisted for use by the push
        /// registration endpoint.</param>
        /// <param name="tagsRequiringAuth">Gets or sets a JSON string
        /// containing a list of tags that require user authentication to be
        /// used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.</param>
        /// <param name="dynamicTagsJson">Gets or sets a JSON string containing
        /// a list of dynamic tags that will be evaluated from user claims in
        /// the push registration endpoint.</param>
        public PushSettings(bool isPushEnabled, string tagWhitelistJson = default(string), string tagsRequiringAuth = default(string), string dynamicTagsJson = default(string))
        {
            IsPushEnabled = isPushEnabled;
            TagWhitelistJson = tagWhitelistJson;
            TagsRequiringAuth = tagsRequiringAuth;
            DynamicTagsJson = dynamicTagsJson;
        }

        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "isPushEnabled")]
        public bool IsPushEnabled { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are
        /// whitelisted for use by the push registration endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "tagWhitelistJson")]
        public string TagWhitelistJson { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require
        /// user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        [JsonProperty(PropertyName = "tagsRequiringAuth")]
        public string TagsRequiringAuth { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that
        /// will be evaluated from user claims in the push registration
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicTagsJson")]
        public string DynamicTagsJson { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}

