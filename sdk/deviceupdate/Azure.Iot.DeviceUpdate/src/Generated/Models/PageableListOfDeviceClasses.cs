// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    /// <summary> The list of device classes. </summary>
    internal partial class PageableListOfDeviceClasses
    {
        /// <summary> Initializes a new instance of PageableListOfDeviceClasses. </summary>
        internal PageableListOfDeviceClasses()
        {
            Value = new ChangeTrackingList<DeviceClass>();
        }

        /// <summary> Initializes a new instance of PageableListOfDeviceClasses. </summary>
        /// <param name="value"> The collection of pageable items. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal PageableListOfDeviceClasses(IReadOnlyList<DeviceClass> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of pageable items. </summary>
        public IReadOnlyList<DeviceClass> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
