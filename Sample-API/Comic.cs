namespace Sample_API
{
    public class Comic : Book
    {
        public enum Types { Manga, Americano, Europeo, Unidentified }

        public string Type { get; set; }
    }
}
