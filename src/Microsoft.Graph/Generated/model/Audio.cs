// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Audio.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Audio>))]
    public partial class Audio
    {

        /// <summary>
        /// Gets or sets album.
        /// The title of the album for this audio file.
        /// </summary>
        [JsonPropertyName("album")]
        public string Album { get; set; }
    
        /// <summary>
        /// Gets or sets albumArtist.
        /// The artist named on the album for the audio file.
        /// </summary>
        [JsonPropertyName("albumArtist")]
        public string AlbumArtist { get; set; }
    
        /// <summary>
        /// Gets or sets artist.
        /// The performing artist for the audio file.
        /// </summary>
        [JsonPropertyName("artist")]
        public string Artist { get; set; }
    
        /// <summary>
        /// Gets or sets bitrate.
        /// Bitrate expressed in kbps.
        /// </summary>
        [JsonPropertyName("bitrate")]
        public Int64? Bitrate { get; set; }
    
        /// <summary>
        /// Gets or sets composers.
        /// The name of the composer of the audio file.
        /// </summary>
        [JsonPropertyName("composers")]
        public string Composers { get; set; }
    
        /// <summary>
        /// Gets or sets copyright.
        /// Copyright information for the audio file.
        /// </summary>
        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }
    
        /// <summary>
        /// Gets or sets disc.
        /// The number of the disc this audio file came from.
        /// </summary>
        [JsonPropertyName("disc")]
        public Int16? Disc { get; set; }
    
        /// <summary>
        /// Gets or sets discCount.
        /// The total number of discs in this album.
        /// </summary>
        [JsonPropertyName("discCount")]
        public Int16? DiscCount { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// Duration of the audio file, expressed in milliseconds
        /// </summary>
        [JsonPropertyName("duration")]
        public Int64? Duration { get; set; }
    
        /// <summary>
        /// Gets or sets genre.
        /// The genre of this audio file.
        /// </summary>
        [JsonPropertyName("genre")]
        public string Genre { get; set; }
    
        /// <summary>
        /// Gets or sets hasDrm.
        /// Indicates if the file is protected with digital rights management.
        /// </summary>
        [JsonPropertyName("hasDrm")]
        public bool? HasDrm { get; set; }
    
        /// <summary>
        /// Gets or sets isVariableBitrate.
        /// Indicates if the file is encoded with a variable bitrate.
        /// </summary>
        [JsonPropertyName("isVariableBitrate")]
        public bool? IsVariableBitrate { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The title of the audio file.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets track.
        /// The number of the track on the original disc for this audio file.
        /// </summary>
        [JsonPropertyName("track")]
        public Int32? Track { get; set; }
    
        /// <summary>
        /// Gets or sets trackCount.
        /// The total number of tracks on the original disc for this audio file.
        /// </summary>
        [JsonPropertyName("trackCount")]
        public Int32? TrackCount { get; set; }
    
        /// <summary>
        /// Gets or sets year.
        /// The year the audio file was recorded.
        /// </summary>
        [JsonPropertyName("year")]
        public Int32? Year { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
