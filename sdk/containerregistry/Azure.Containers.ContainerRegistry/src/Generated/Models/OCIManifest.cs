// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Returns the requested OCI Manifest file. </summary>
    public partial class OCIManifest : Manifest
    {
        /// <summary> Initializes a new instance of OCIManifest. </summary>
        public OCIManifest()
        {
            Layers = new ChangeTrackingList<Descriptor>();
        }

        /// <summary> Initializes a new instance of OCIManifest. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="config"> V2 image config descriptor. </param>
        /// <param name="layers"> List of V2 image layer information. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        internal OCIManifest(int? schemaVersion, Descriptor config, IList<Descriptor> layers, Annotations annotations) : base(schemaVersion)
        {
            Config = config;
            Layers = layers;
            Annotations = annotations;
        }

        /// <summary> V2 image config descriptor. </summary>
        public Descriptor Config { get; set; }
        /// <summary> List of V2 image layer information. </summary>
        public IList<Descriptor> Layers { get; }
        /// <summary> Additional information provided through arbitrary metadata. </summary>
        public Annotations Annotations { get; set; }
    }
}
