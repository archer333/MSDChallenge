﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataTransform.Models
{
    class User
    {
        [BsonId]
        public string Id { get; set; }
    }
}
