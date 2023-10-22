namespace Sample_API
{
    public class Book
    {
        public string Name { get; set; }

        public DateTime PublicationDate {get; set; }

        public string Writer { get; set; }

        public string GetResume() {
            return $"This is a resume of {Name}";
        }
    }
}