using bookstore.Models;
using bookstore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}



        //////////////////-----------Classes older than  14 starts from here-------------//////////////////

        //public string GetAllBooks()
        //{
        //    return "All Books";
        //}

        //public string GetBook(int id)
        //{
        //    return $"Book with id = {id}";
        //}

        //public string SearchBooks(string bookname, string authorname)
        //{
        //    return $"Book with name = {bookname} & author = {authorname}";
        //}

        //////////////////-----------Classes older than 14 ends here-------------//////////////////





        //////////////////-----------Class 14 starts from here-------------//////////////////
        ///(#14) Model in Asp.Net core | Asp.Net Core tutorial


        //private readonly BookRepository _bookRepository;
        //public BookController()
        //{
        //    _bookRepository = new BookRepository();
        //}




        //public List<BookModel> GetAllBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}

        //public BookModel GetBook(int id)
        //{
        //    return _bookRepository.GetBookById(id);
        //}

        //public List<BookModel> SearchBooks(string bookname, string authorname)
        //{
        //    return _bookRepository.SearchBook(bookname, authorname);
        //}




        ///(#14) Model in Asp.Net core | Asp.Net Core tutorial
        //////////////////-----------Class 14 ends here-------------//////////////////





        //////////////////-----------Class 15 starts from here-----------//////////////////
        ///(#15) View in asp.net core application


        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }




        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookname, string authorname)
        {
            return _bookRepository.SearchBook(bookname, authorname);
        }




        ///(#15) View in asp.net core application
        ///-----------Class 15 ends here-------------///
    }
}
