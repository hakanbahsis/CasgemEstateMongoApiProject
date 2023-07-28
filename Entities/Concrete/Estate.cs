﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Estate
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public List<string> Pictures { get; set; }
        public string RealEstate { get; set; }
        public string Type { get; set; }
        public string NumberOfRooms { get; set; }
        public int AgeOfBuilding { get; set; }
        public bool Furnished { get; set; }
        public bool WithinaBuildingComplex { get; set; }
        public int FloorNumber { get; set; }
        public int NumberOfFloors { get; set; }
    }
}
