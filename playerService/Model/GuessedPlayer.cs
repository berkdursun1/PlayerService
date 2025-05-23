﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace playerService.Model
{
    public class GuessedPlayer
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public int Age { get; set; }
        public List<string> Nationality { get; set; }
        public string? Foot { get; set; }
        public string? ImageUrl { get; set; }
        public List<string> Teams { get; set; }
        public int Matchs { get; set; }
        public int Scores { get; set; }
        public int Asists { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            Console.WriteLine($"teams => {this.Teams.Count}");
        }

    }
}
