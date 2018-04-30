using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace UWPTeamWork
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Page4 : Page
    {
        private List<Book> Books;
        public Page4()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
        }
        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            ResultTextBlock.Text = "You selected " + book.Title;
        }
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend", CoverImage = "Assets/7.png" });
            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Vero Tation", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookId = 9, Title = "Suscipit Ad", Author = "Jack Tibbles", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookId = 10, Title = "Decima", Author = "Tuffy Tibbles", CoverImage = "Assets/10.png" });
            books.Add(new Book { BookId = 11, Title = "Erat", Author = "Volupat", CoverImage = "Assets/11.png" });
            books.Add(new Book { BookId = 12, Title = "Consequat", Author = "Est Possim", CoverImage = "Assets/12.png" });
            books.Add(new Book { BookId = 13, Title = "Aliquip", Author = "Magna", CoverImage = "Assets/13.png" });

            return books;
        }
    }
}
