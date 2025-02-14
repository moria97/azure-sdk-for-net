// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventConnectionRejectedEventDataConverter))]
    public partial class MediaLiveEventConnectionRejectedEventData
    {
        internal static MediaLiveEventConnectionRejectedEventData DeserializeMediaLiveEventConnectionRejectedEventData(JsonElement element)
        {
            Optional<string> ingestUrl = default;
            Optional<string> streamId = default;
            Optional<string> encoderIp = default;
            Optional<string> encoderPort = default;
            Optional<string> resultCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamId"))
                {
                    streamId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderIp"))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultCode"))
                {
                    resultCode = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventConnectionRejectedEventData(ingestUrl.Value, streamId.Value, encoderIp.Value, encoderPort.Value, resultCode.Value);
        }

        internal partial class MediaLiveEventConnectionRejectedEventDataConverter : JsonConverter<MediaLiveEventConnectionRejectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventConnectionRejectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventConnectionRejectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventConnectionRejectedEventData(document.RootElement);
            }
        }
    }
}
