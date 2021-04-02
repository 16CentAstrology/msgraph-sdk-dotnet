// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Chat.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Chat : Entity
    {
    
		///<summary>
		/// The Chat constructor
		///</summary>
        public Chat()
        {
            this.ODataType = "microsoft.graph.chat";
        }
	
        /// <summary>
        /// Gets or sets chat type.
        /// Specifies the type of chat. Possible values are:group, oneOnOne and meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chatType", Required = Newtonsoft.Json.Required.Default)]
        public ChatType? ChatType { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time at which the chat was created. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Date and time at which the chat was renamed or list of members were last changed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets topic.
        /// (Optional) Subject or topic for the chat. Only available for group chats.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topic", Required = Newtonsoft.Json.Required.Default)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets installed apps.
        /// A collection of all the apps in the chat. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedApps", Required = Newtonsoft.Json.Required.Default)]
        public IChatInstalledAppsCollectionPage InstalledApps { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// A collection of all the members in the chat. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IChatMembersCollectionPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// A collection of all the messages in the chat. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Newtonsoft.Json.Required.Default)]
        public IChatMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets tabs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tabs", Required = Newtonsoft.Json.Required.Default)]
        public IChatTabsCollectionPage Tabs { get; set; }
    
    }
}

