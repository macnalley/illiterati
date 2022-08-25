using System.Collections.Generic;

namespace Illiterati.Quiz.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Quote>? Quotes { get; set; }
        public virtual ICollection<Genre>? Genres { get; set; }
    }

    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get { return $"{FirstName} {LastName}"; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Work>? Works { get; set; }
        public virtual ICollection<Genre>? Genres { get; set; }
        public virtual ICollection<Quote>? Quotes { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Work>? Works { get; set; }
        public ICollection<Author>? Authors { get; set; }
    }
}