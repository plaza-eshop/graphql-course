using System.Collections.Generic;

namespace LibraryApp.Domain
{
    public class BookRepository
    {
        private static List<Book> books = null;

        static BookRepository()
        {
            var authorRepository = new AuthorRepository();
            var simonDeBeauvoir = authorRepository.GetAuthor("Simone", "de Beauvoir");
            var ernestHemingway = authorRepository.GetAuthor("Ernest", "Hemingway");
            var mikhailBulgakov = authorRepository.GetAuthor("Mikhail", "Bulgakov");

            books = new List<Book>
            {
                new Book{
                    Auther = simonDeBeauvoir,
                    Isbn = "978-3-16-148410-0",
                    PublisYear = 1949,
                    Size = BookSizes.ImperialOctavo,
                    Title = "The Second Sex",
                },
                new Book{
                    Auther = simonDeBeauvoir,
                    Isbn = "578-0-12-384478-1",
                    PublisYear = 1943,
                    Size = BookSizes.Folio,
                    Title = "She Came to Stay",
                },
                new Book{
                    Auther = ernestHemingway,
                    Isbn = "579-4-19-775135-1",
                    PublisYear = 1952,
                    Size = BookSizes.MediumOctavo,
                    Title = "The Old Man and the Sea",
                },
                new Book{
                    Auther = ernestHemingway,
                    Isbn = "895-2-28-184652-5",
                    PublisYear = 1940,
                    Size = BookSizes.Octavo,
                    Title = "For Whom the Bell Tolls"
                },
                new Book{
                    Auther = ernestHemingway,
                    Isbn = "294-1-19-984537-0",
                    PublisYear = 1929,
                    Size = BookSizes.MediumOctavo,
                    Title = "A Farewell to Arms"
                },
                new Book{
                    Auther = mikhailBulgakov,
                    Isbn = "879-2-20-791455-1",
                    PublisYear = 1929,
                    Size = BookSizes.SuperOctavo,
                    Title = "The Master and Margarita"
                }
            };

        }

    }

}
