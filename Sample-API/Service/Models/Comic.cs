using static Sample_API.Service.Models.Character;

namespace Sample_API.Service.Models
{
    public class Comic
    {
        public int id { get; set; }
        public int digitalId { get; set; }
        public string title { get; set; }
        public int issueNumber { get; set; }
        public string variantDescription { get; set; }
        public object description { get; set; }
        public DateTime modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public int pageCount { get; set; }
        public object[] textObjects { get; set; }
        public string resourceURI { get; set; }
        public Url[] urls { get; set; }
        public Series series { get; set; }
        public Variant[] variants { get; set; }
        public object[] collections { get; set; }
        public object[] collectedIssues { get; set; }
        public Date[] dates { get; set; }
        public Price[] prices { get; set; }
        public Image[] images { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public Stories stories { get; set; }
        public Events events { get; set; }

        public class Creators
        {
            public int available { get; set; }
            public string collectionURI { get; set; }
            public Item[] items { get; set; }
            public int returned { get; set; }
        }

        public class Characters
        {
            public int available { get; set; }
            public string collectionURI { get; set; }
            public Item1[] items { get; set; }
            public int returned { get; set; }
        }

        public class Variant
        {
            public string resourceURI { get; set; }
            public string name { get; set; }
        }

        public class Date
        {
            public string type { get; set; }
            public DateTime date { get; set; }
        }

        public class Price
        {
            public string type { get; set; }
            public float price { get; set; }
        }

        public class Image
        {
            public string path { get; set; }
            public string extension { get; set; }
        }

    }
}
