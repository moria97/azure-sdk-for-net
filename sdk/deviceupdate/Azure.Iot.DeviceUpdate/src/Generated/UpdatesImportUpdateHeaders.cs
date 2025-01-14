// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate
{
    internal partial class UpdatesImportUpdateHeaders
    {
        private readonly Response _response;
        public UpdatesImportUpdateHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Url to retrieve the import operation status. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> Url to retrieve the import operation status. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
