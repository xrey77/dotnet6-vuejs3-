using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet6_vuejs3.Entities;

public class Users {

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; } 

    [Required]
    [BsonElement("lastname")]
    public string Lastname { get; set; } = default!;

    [Required]
    [BsonElement("firstname")]
    public string Firstname { get; set; } = default!;
    
    [Required]
    [BsonElement("emailadd")]
    public string Emailadd { get; set; } = default!;

    [Required]
    [BsonElement("mobileno")]
    public string Mobileno { get; set; } = default!;

    [Required]
    [BsonElement("username")]
    public string Username { get; set; } = default!;

    [Required]
    [BsonElement("password")]
    public string Password { get; set; } = default!;
}