// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    public partial class Operation
    {
        internal static Operation DeserializeOperation(JsonElement element)
        {
            string operationId = default;
            OperationStatus status = default;
            Optional<UpdateId> updateId = default;
            Optional<string> resourceLocation = default;
            Optional<Error> error = default;
            Optional<string> traceId = default;
            DateTimeOffset lastActionDateTime = default;
            DateTimeOffset createdDateTime = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateId = UpdateId.DeserializeUpdateId(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceLocation"))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = Error.DeserializeError(property.Value);
                    continue;
                }
                if (property.NameEquals("traceId"))
                {
                    traceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"))
                {
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new Operation(operationId, status, updateId.Value, resourceLocation.Value, error.Value, traceId.Value, lastActionDateTime, createdDateTime, etag.Value);
        }
    }
}
