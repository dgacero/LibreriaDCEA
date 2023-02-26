using LibreriaDCEA.Shared.Models;

namespace LibreriaDCEA.Shared.Services;
public class BookListService {
    public static List<Book> Books = new List<Book> {
        new Book{
            Id = 1,
            Title = "Learning Python",
            Author = "Mark Lutz",
            ISBN = "978-1449355739",
            Editorial = "O'Reilly Media",
            Edition = "Quinta",
            Price = 462.22f,
            Image = "https://m.media-amazon.com/images/I/614DWyHLwWS.jpg"
        },
        new Book{
            Id = 2,
            Title = "Learning the bash Shell",
            Author = "Cameron Newham & Bill Rosenblatt",
            Editorial = "O'Reilly Media",
            ISBN = "978-0596009656",
            Edition = "Tercera",
            Price = 269.36f,
            Image = "https://m.media-amazon.com/images/I/91ylEPQwu5L.jpg"
        },
        new Book{
            Id = 3,
            Title = "Learning Agile",
            Author = "Andrew Stellman & Jennifer Greene",
            Editorial = "O'Reilly Media",
            ISBN = "978-1449331924",
            Edition = "Primera",
            Price = 822.96f,
            Image = "https://m.media-amazon.com/images/I/71ws2w9dTfL.jpg"
        },
        new Book{
            Id = 4,
            Title = "Learning R",
            Author = "Richard Cotton",
            Editorial = "O'Reilly Media",
            ISBN = "978-1449357108",
            Edition = "Primera",
            Price = 766.36f,
            Image = "https://m.media-amazon.com/images/I/71aIBHeQPkL.jpg"
        },
        new Book{
            Id = 5,
            Title = "Learning UML 2.0",
            Author = "Russ Miles & Kim Hamilton",
            Editorial = "O'Reilly Media",
            ISBN = "978-0596009823",
            Edition = "Primera",
            Price = 814.42f,
            Image = "https://m.media-amazon.com/images/I/91XUqcBENbL.jpg"
        },
        new Book{
            Id = 6,
            Title = "Learning XML",
            Author = "Erik T. Ray",
            Editorial = "O'Reilly Media",
            ISBN = "978-0596004200",
            Edition = "Segunda",
            Price = 467.24f,
            Image = "https://m.media-amazon.com/images/I/51RT7H4bYRL.jpg"
        },
        new Book{
            Id = 7,
            Title = "Learning Visual Basic .Net",
            Author = "Jesse Liberty",
            Editorial = "O'Reilly Media",
            ISBN = "978-0596003869",
            Edition = "Primera",
            Price = 540.72f,
            Image = "https://m.media-amazon.com/images/I/91qGmQd7LEL.jpg"
        },
        new Book{
            Id = 8,
            Title = "Learning SPARQL",
            Author = "Bob DuCharme",
            Editorial = "O'Reilly Media",
            ISBN = "978-1449371432",
            Edition = "Segunda",
            Price = 264.41f,
            Image = "https://m.media-amazon.com/images/I/71JaRECtJjS.jpg"
        },
        new Book{
            Id = 9,
            Title = "Learning Web App Developvment",
            Author = "Semmy Purewal",
            Editorial = "O'Reilly Media",
            ISBN = "978-1449370190",
            Edition = "Primera",
            Price = 738.15f,
            Image = "https://m.media-amazon.com/images/I/71Q8O4J8e6L.jpg"
        },
        new Book{
            Id = 10,
            Title = "Learning Spark",
            Author = "Holden Karau, Andy Kowinski, Patrick Wendell & Matei Zaharia",
            Editorial = "O'Reilly Media",
            ISBN = "978-1449358624",
            Edition = "Primera",
            Price = 668.20f,
            Image = "https://m.media-amazon.com/images/I/71KmMMrW+wL.jpg"
        }
    };
}