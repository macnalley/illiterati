using System.Collections.Generic;

namespace Illiterati.Quiz.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public List<Quote> Quotes { get; set; }
        public List<Movement> Movements { get; set; }
    }

    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int WorkId { get; set; }
        public Work Work { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get { return $"{FirstName} {LastName}"; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Work> Works { get; set; }
        public List<Movement> Movements { get; set; }
        public List<Quote> Quotes { get; set; }
    }

    public class Movement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Work> Works { get; set; }
        public List<Author> Authors { get; set; }
    }
}