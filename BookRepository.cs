using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Nagarro", Description = "This is the description for MVC Book",Category = "Programing", Language = "English", TotalPages =134 },
                new BookModel() { Id = 2, Title = "C#", Author = "Monika", Description = "This is the description for C# Book",Category = "Framework", Language = "Chinees", TotalPages =567},
                new BookModel() { Id = 3, Title = "Java", Author = "United", Description = "This is the description for Java Book",Category = "Developer", Language = "Hindi", TotalPages =897},
                new BookModel() { Id = 4, Title = "Php", Author = "VBPS", Description = "This is the description for php Book",Category = "Programing", Language = "English", TotalPages =100},
                new BookModel() { Id = 6, Title = "ruby", Author = "NUSI", Description = "This is the description for Devops Book",Category = "Devops", Language = "English", TotalPages =800},
            };  
        }
    }
}
