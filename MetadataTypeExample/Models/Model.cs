using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MetadataTypeExample.Metadatas;


namespace MetadataTypeExample.Models
{

    [MetadataType(typeof(NameMetadata))]
    public class Name
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    [MetadataType(typeof(LocationMetadata))]
    public class Location
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object Postcode { get; set; }
    }

    [MetadataType(typeof(LoginMetadata))]
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
    }


    [MetadataType(typeof(IdMetadata))]
    public class Id
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }


    [MetadataType(typeof(PictureMetadata))]
    public class Picture
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }

    [MetadataType(typeof(ResultMetadata))]
    public class Result
    {
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public Login Login { get; set; }
        public string Dob { get; set; }
        public string Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Id Id { get; set; }
        public Picture Picture { get; set; }
        public string Nat { get; set; }
    }

    [MetadataType(typeof(InfoMetadata))]
    public class Info
    {
        public string Seed { get; set; }
        public int Results { get; set; }
        public int Page { get; set; }
        public string Version { get; set; }
    }

    [MetadataType(typeof(ExampleMetadata))]
    public class Example
    {
        public IList<Result> Results { get; set; }
        public Info Info { get; set; }
    }
}