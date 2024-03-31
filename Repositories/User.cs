using MongoDB.Bson;

public class User
{
    public string Email { get; internal set; }
    public ObjectId Id { get; internal set; }
    public string Password { get; internal set; }
}