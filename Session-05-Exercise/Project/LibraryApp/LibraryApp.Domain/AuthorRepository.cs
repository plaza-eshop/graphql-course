using System;
using System.Collections.Generic;

namespace LibraryApp.Domain
{
    public class AuthorRepository
    {
        private static List<Author> authors = null;

        static AuthorRepository()
        {
            authors = new List<Author>
            {
                new Author{
                    Firstname = "Simone",
                    LastName = "de Beauvoir",
                    Gender = Genders.Female
                },
                new Author{
                    Firstname = "Ernest",
                    LastName = "Hemingway",
                    Gender = Genders.Male
                },
                new Author{
                    Firstname = "Mikhail",
                    LastName = "Bulgakov",
                    Gender = Genders.Male
                },
            };

        }

        public Author GetAuthor(string firstName, string lastName)
        {
            return authors.FirstOrDefault(author =>
                author.Firstname.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }

    }

}
