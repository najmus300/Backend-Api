﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AuthApp.Models
{
    public class UserModel
    {
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
