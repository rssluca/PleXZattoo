// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var channelGroup = ChannelGroup.FromJson(jsonString);

namespace PleXZattoo
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Channels
    {
        [JsonProperty("channel_groups")]
        public List<ChannelGroupElement> ChannelGroups { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class ChannelGroupElement
    {
        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Channel
    {
        [JsonProperty("display_alias")]
        public string DisplayAlias { get; set; }

        [JsonProperty("sharing")]
        public bool Sharing { get; set; }

        [JsonProperty("is_radio")]
        public bool IsRadio { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cid")]
        public string Cid { get; set; }

        [JsonProperty("recording")]
        public bool Recording { get; set; }

        [JsonProperty("qualities")]
        public List<Quality> Qualities { get; set; }

        [JsonProperty("recommendations")]
        public bool Recommendations { get; set; }

        [JsonProperty("selective_recall_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? SelectiveRecallSeconds { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("aliases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Aliases { get; set; }
    }

    public partial class Quality
    {
        [JsonProperty("logo_black_84")]
        public string LogoBlack84 { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("stream_types")]
        public List<StreamType> StreamTypes { get; set; }

        [JsonProperty("level")]
        public Level Level { get; set; }

        [JsonProperty("logo_white_42")]
        public string LogoWhite42 { get; set; }

        [JsonProperty("logo_token")]
        public string LogoToken { get; set; }

        [JsonProperty("logo_black_42")]
        public string LogoBlack42 { get; set; }

        [JsonProperty("logo_white_84")]
        public string LogoWhite84 { get; set; }

        [JsonProperty("availability")]
        public Availability Availability { get; set; }

        [JsonProperty("drm_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DrmRequired { get; set; }
    }

    public enum Availability { Available, Subscribable };

    public enum Level { Hd, Sd };

    public enum StreamType { Dash, DashPlayready, DashWidevine, Hds, Hls, Hls5, Hls5Fairplay, Hls7, Hls7Fairplay, SmoothPlayready };

    public partial class Channels
    {
        public static Channels FromJson(string json) => JsonConvert.DeserializeObject<Channels>(json, PleXZattoo.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Channels self) => JsonConvert.SerializeObject(self, PleXZattoo.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AvailabilityConverter.Singleton,
                LevelConverter.Singleton,
                StreamTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AvailabilityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Availability) || t == typeof(Availability?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "available":
                    return Availability.Available;
                case "subscribable":
                    return Availability.Subscribable;
            }
            throw new Exception("Cannot unmarshal type Availability");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Availability)untypedValue;
            switch (value)
            {
                case Availability.Available:
                    serializer.Serialize(writer, "available");
                    return;
                case Availability.Subscribable:
                    serializer.Serialize(writer, "subscribable");
                    return;
            }
            throw new Exception("Cannot marshal type Availability");
        }

        public static readonly AvailabilityConverter Singleton = new AvailabilityConverter();
    }

    internal class LevelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Level) || t == typeof(Level?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "hd":
                    return Level.Hd;
                case "sd":
                    return Level.Sd;
            }
            throw new Exception("Cannot unmarshal type Level");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Level)untypedValue;
            switch (value)
            {
                case Level.Hd:
                    serializer.Serialize(writer, "hd");
                    return;
                case Level.Sd:
                    serializer.Serialize(writer, "sd");
                    return;
            }
            throw new Exception("Cannot marshal type Level");
        }

        public static readonly LevelConverter Singleton = new LevelConverter();
    }

    internal class StreamTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StreamType) || t == typeof(StreamType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "dash":
                    return StreamType.Dash;
                case "dash_playready":
                    return StreamType.DashPlayready;
                case "dash_widevine":
                    return StreamType.DashWidevine;
                case "hds":
                    return StreamType.Hds;
                case "hls":
                    return StreamType.Hls;
                case "hls5":
                    return StreamType.Hls5;
                case "hls5_fairplay":
                    return StreamType.Hls5Fairplay;
                case "hls7":
                    return StreamType.Hls7;
                case "hls7_fairplay":
                    return StreamType.Hls7Fairplay;
                case "smooth_playready":
                    return StreamType.SmoothPlayready;
            }
            throw new Exception("Cannot unmarshal type StreamType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StreamType)untypedValue;
            switch (value)
            {
                case StreamType.Dash:
                    serializer.Serialize(writer, "dash");
                    return;
                case StreamType.DashPlayready:
                    serializer.Serialize(writer, "dash_playready");
                    return;
                case StreamType.DashWidevine:
                    serializer.Serialize(writer, "dash_widevine");
                    return;
                case StreamType.Hds:
                    serializer.Serialize(writer, "hds");
                    return;
                case StreamType.Hls:
                    serializer.Serialize(writer, "hls");
                    return;
                case StreamType.Hls5:
                    serializer.Serialize(writer, "hls5");
                    return;
                case StreamType.Hls5Fairplay:
                    serializer.Serialize(writer, "hls5_fairplay");
                    return;
                case StreamType.Hls7:
                    serializer.Serialize(writer, "hls7");
                    return;
                case StreamType.Hls7Fairplay:
                    serializer.Serialize(writer, "hls7_fairplay");
                    return;
                case StreamType.SmoothPlayready:
                    serializer.Serialize(writer, "smooth_playready");
                    return;
            }
            throw new Exception("Cannot marshal type StreamType");
        }

        public static readonly StreamTypeConverter Singleton = new StreamTypeConverter();
    }
}
