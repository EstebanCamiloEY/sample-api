﻿namespace Sample_API.Service.Models
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public string resourceURI { get; set; }
        public Comics comics { get; set; }
        public Series series { get; set; }
        public Stories stories { get; set; }
        public Events events { get; set; }
        public Url[] urls { get; set; }

        public class Comics
        {
            public int available { get; set; }
            public string collectionURI { get; set; }
            public Item[] items { get; set; }
            public int returned { get; set; }
        }

        public class Item
        {
            public string resourceURI { get; set; }
            public string name { get; set; }
        }

        public class Series
        {
            public int available { get; set; }
            public string collectionURI { get; set; }
            public Item1[] items { get; set; }
            public int returned { get; set; }
        }

        public class Item1
        {
            public string resourceURI { get; set; }
            public string name { get; set; }
        }

        public class Stories
        {
            public int available { get; set; }
            public string collectionURI { get; set; }
            public Item2[] items { get; set; }
            public int returned { get; set; }
        }

        public class Item2
        {
            public string resourceURI { get; set; }
            public string name { get; set; }
            public string type { get; set; }
        }

        public class Events
        {
            public int available { get; set; }
            public string collectionURI { get; set; }
            public Item3[] items { get; set; }
            public int returned { get; set; }
        }

        public class Item3
        {
            public string resourceURI { get; set; }
            public string name { get; set; }
        }

        public class Url
        {
            public string type { get; set; }
            public string url { get; set; }
        }
    }
}
