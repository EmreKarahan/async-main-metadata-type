using System.Collections.Generic;
using MetadataTypeExample.Models;
using Newtonsoft.Json;

namespace MetadataTypeExample.Metadatas
{
    public sealed class NameMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public sealed class LocationMetadata
    {
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("postcode")]
        public object Postcode { get; set; }
    }

    public class LoginMetadata
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("salt")]
        public string Salt { get; set; }
        [JsonProperty("md5")]
        public string Md5 { get; set; }
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }
        [JsonProperty("sha256")]
        public string Sha256 { get; set; }
    }


    public sealed class IdMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public sealed class PictureMetadata
    {
        [JsonProperty("large")]
        public string Large { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public sealed class ResultMetadata
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("name")]
        public Name Name { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("login")]
        public Login Login { get; set; }
        [JsonProperty("dob")]
        public string Dob { get; set; }
        [JsonProperty("registered")]
        public string Registered { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("cell")]
        public string Cell { get; set; }
        [JsonProperty("id")]
        public Id Id { get; set; }
        [JsonProperty("picture")]
        public Picture Picture { get; set; }
        [JsonProperty("nat")]
        public string Nat { get; set; }
    }


    public sealed class InfoMetadata
    {
        [JsonProperty("seed")]
        public string Seed { get; set; }
        [JsonProperty("results")]
        public int Results { get; set; }
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }


    public sealed class ExampleMetadata
    {
        [JsonProperty("results")]
        public IList<Result> Results { get; set; }
        [JsonProperty("info")]
        public Info Info { get; set; }
    }
}
