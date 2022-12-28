using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace myfirstproject.Mini_Project
{
    /*class Author2
    {
        public int authorId;
        public string authorName;

        public Author2(int authorId, string authorName)
        {
            this.authorId = authorId;
            this.authorName = authorName;
        }
    }
    class Book2
    {
        public int bookId;
        public string bookName;
        public int bookPrice;
        public Author bookAuthor;

        public Book2(int bookId, string bookName, int bookPrice, Author bookAuthor)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookPrice = bookPrice;
            this.bookAuthor = bookAuthor;
        }
    }

    class Operations
    {
        public ArrayList BooksList = new ArrayList();
        public void InsertData()
        {
            Console.Write("\t\t\tEnter how many book you want to insert : ");
            int No_ofBooks = int.Parse(Console.ReadLine());
            int bookId, bookPrice, authorId;
            string bookName, authorName;
            for (int i = 0; i < No_ofBooks; i++)
            {
                bool IsPresent = false;
                Console.Write("\t\t\tEnter Book's Id : ");
                bookId = int.Parse(Console.ReadLine());
                foreach (Book bk in BooksList)
                {
                    if (bk.bookId.Equals(bookId))
                    {
                        Console.WriteLine("\t\t\tPlease Enter Unique Book Id !! " +
                                    bookId + " is already Present");
                        IsPresent = true;
                        No_ofBooks++;//To increase the user entered books size
                        break;
                    }
                }
                if (!IsPresent)
                {
                    try
                    {
                        Console.Write("\t\t\tEnter Book's Name : ");
                        bookName = Console.ReadLine();
                        Console.Write("\t\t\tEnter Book's Price : ");
                        bookPrice = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\tEnter Book's AuthorId : ");
                        authorId = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\tEnter Book's Author Name : ");
                        authorName = Console.ReadLine();
                        BooksList.Add(new Book(bookId, bookName, bookPrice, new Author(authorId, authorName)));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\t\t\tPlease Enter Proper Format...ReEnter..");
                        No_ofBooks++;
                    }
                }
            }
        }
        public void DisplayData()
        {
            if (BooksList.Count != 0)
            {
                Console.Write("\t\t\tEnter Book Id : ");
                int bookId = int.Parse(Console.ReadLine());
                bool IsDisplay = false;
                foreach (Book bk in BooksList)
                {
                    if (bk.bookId.Equals(bookId))
                    {
                        Console.WriteLine("\t\t\t.......................");
                        Console.WriteLine("\t\t\tBook Details : \n\t\t\tBook Id : \t" + bk.bookId + "\n\t\t\tBook Name : \t" + bk.bookName
                               + "\n\t\t\tBook Price : \t" + bk.bookPrice + "\n\t\t\tAuthor Id : \t" + bk.bookAuthor.authorId +
                                 "\n\t\t\tAuthor Name : \t" + bk.bookAuthor.authorName);
                        Console.WriteLine("\t\t\t.......................");
                        IsDisplay = true;
                        break;
                    }
                }
                if (!IsDisplay)//if book id is not present 
                {
                    Console.WriteLine($"\t\t\t{bookId} is not present in current book list");
                }
            }
            else
            {
                Console.WriteLine("\t\t\tCurrent booklist is empty !!!");
                Console.WriteLine("\t\t\tPlease insert data first");
            }
        }
        public void UpdateData()
        {
            if (BooksList.Count != 0)
            {
                Console.Write("\t\t\tEnter Book Id : ");
                int bookId = int.Parse(Console.ReadLine());
                bool IsUpdate = false;
                foreach (Book bk in BooksList)
                {
                    if (bk.bookId.Equals(bookId))
                    {
                        Console.Write("\t\t\tEnter New Price : ");
                        bk.bookPrice = int.Parse(Console.ReadLine());
                        IsUpdate = true;
                        break;
                    }
                }
                if (!IsUpdate)//if book id is not present 
                {
                    Console.WriteLine($"\t\t\t{bookId} is not present in current book list");
                }
                else
                {
                    Console.WriteLine("\t\t\tPrice Changed Successfully");
                }
            }
            else
            {
                Console.WriteLine("\t\t\tCurrent booklist is empty !!!");
                Console.WriteLine("\t\t\tPlease insert data first");
            }
        }

        public void DeleteData()
        {
            if (BooksList.Count != 0)
            {
                Console.Write("\t\t\tEnter Book Id : ");
                int bookId = int.Parse(Console.ReadLine());
                bool IsDelete = false;
                foreach (Book bk in BooksList)
                {
                    if (bk != null && bk.bookId.Equals(bookId))
                    {
                        BooksList.Remove(bk);
                        IsDelete = true;
                        break;
                    }
                }
                if (!IsDelete)//if book id is not present 
                {
                    Console.WriteLine($"\t\t\t{bookId} is not present in current book list");
                }
                else
                {
                    Console.WriteLine("\t\t\tBook Details Deleted Successfully");
                }
            }
            else
            {
                Console.WriteLine("\t\t\tCurrent booklist is empty !!!");
                Console.WriteLine("\t\t\tPlease insert data first");
            }
        }
    }

    class BookList
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            int Stopper = 1;
            do
            {
                Console.WriteLine("\n\t\t\tWelcome To Crud Operations : \n\t\t\tPress 1 To Insert Data\n\t\t\t" +
                    "Press 2 To Display Data\n\t\t\tPress 3 To Update Data\n\t\t\tPress 4 To Delete Data\n\t\t\t" +
                    "Press 5 To Exit");
                Console.Write("\t\t\tEnter here... ");
                int Key = int.Parse(Console.ReadLine());
                switch (Key)
                {
                    case 1:
                        op.InsertData();
                        break;
                    case 2:
                        op.DisplayData();
                        break;
                    case 3:
                        op.UpdateData();
                        break;
                    case 4:
                        op.DeleteData();
                        break;
                    case 5:
                        Stopper = 0;
                        break;
                    default:
                        Console.WriteLine("\t\t\tInvalid Key");
                        break;
                }
            } while (Stopper != 0);
        }
    }
    class Author1
    {
        public int authorId;
        public string authorName;

        public Author1(int authorId, string authorName)
        {
            this.authorId = authorId;
            this.authorName = authorName;
        }
    }
    class Book1
    {

        public int bid;
        public string bname;
        public int bprice;
        public Author author;

        public Book1(int bid, string bname, int bprice, Author author)
        {
            this.bid = bid;
            this.bname = bname;
            this.bprice = bprice;
            this.author = author;
        }
    }
    class BooksStore1
    {
        // public Book[] bookslist = new Book[5];

        ArrayList bookslist = new ArrayList();

        public int BookSize = -1;
        public void Insert()
        {
            Console.Write("Enter Number of book you want to insert : ");
            int NumOfBook = int.Parse(Console.ReadLine());
            if (NumOfBook <= bookslist.Count)
            {
                for (int i = 0; i < NumOfBook; i++)
                {
                    bool IsPresent = false;
                    Console.Write("Enter the Book Id : ");
                    int bid = int.Parse(Console.ReadLine());
                    foreach (Book book in bookslist) //To check book id is already present or not
                    {
                        if (book.bid.Equals(bid))//To avoid null object reference
                        {
                            Console.WriteLine("Please Enter Unique Book Id !! " +
                                    bid + " is already Present");
                            IsPresent = true;
                            NumOfBook++;//To increase the user entered books size
                            break;
                        }
                    }
                    if (!IsPresent)
                    {
                        Console.Write("Enter the Book Name : ");
                        string bname = Console.ReadLine();
                        Console.Write("Enter the Book Price : ");
                        int bprice = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Book Author Id : ");
                        int authorid = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Book Author Name : ");
                        string authorname = Console.ReadLine();
                        bookslist[i] = new Book(bid, bname, bprice, new Author(authorid, authorname));
                    }
                }
                BookSize = NumOfBook;
            }
            else
            {
                Console.WriteLine("Error!! Number of books are more than " + bookslist.Count);
            }
        }
        public void Display(int bookid)
        {
            if (bookslist.Count != 0)
            {
                Console.WriteLine(bookslist.Count + "...........................");
                bool IsDisplay = false;
                foreach (Book book in bookslist)
                {
                    if (book.bid.Equals(book.bid))
                    {
                        Console.WriteLine("Book Details : \nId : " + book.bid + "\nName : " + book.bname
                                + "\nPrice : " + book.bprice + "\nAuthor Id : " + book.author.authorId +
                                  "\nAuthor Name : " + book.author.authorName);
                        IsDisplay = true;
                    }
                }
                if (!IsDisplay)
                {
                    Console.WriteLine($"{bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Update(int Bookid)
        {
            if (bookslist.Count != 0)
            {
                bool result = false;
                foreach (Book book in bookslist)
                {
                    if (book.bid.Equals(book.bid))
                    {
                        Console.WriteLine("Enter new price");
                        book.bprice = int.Parse(Console.ReadLine());
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Price Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Delete(int bid)
        {
            if (bookslist.Count != 0)
            {
                bool result = false;
                foreach (Book book in bookslist)
                {
                    if (book != null && book.bid.Equals(bid))
                    {
                        bookslist.Remove(book);
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Delete the data Successfully...");
                }
                else
                {
                    Console.WriteLine("{bid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
    }
    class BookStroreArrayList
    {
        static void Main(string[] args)
        {
            BooksStore1 bk = new BooksStore1();
            int Stopper = 1;
            do
            {
                Console.WriteLine("\n\nCrud Operations : \nPress 1 To Insert Data\nPress 2 To Fetch Data" +
                    $"\nPress 3 To Update Data\nPress 4 To Delete Data\nPress 5 To Exit");
                Console.Write("Enter here..");
                int Key = int.Parse(Console.ReadLine());
                switch (Key)
                {
                    case 1:
                        bk.Insert();
                        break;
                    case 2:
                        Console.Write("Enter Book's Id : ");
                        bk.Display(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Enter Book's Id : ");
                        bk.Update(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.Write("Enter Book's Id : ");
                        bk.Delete(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Stopper = 0;
                        break;
                    default:
                        Console.Write("Invalid Key");
                        break;
                }
            } while (Stopper != 0);

        }
    }*/
    class Author
    {
        public int authorId;
        public string authorName;

        public Author(int authorId, string authorName)
        {
            this.authorId = authorId;
            this.authorName = authorName;
        }
    }
    class Book
    {
        public int bid;
        public string bname;
        public int bprice;
        public Author author;

        public Book(int bid, string bname, int bprice, Author author)
        {
            this.bid = bid;
            this.bname = bname;
            this.bprice = bprice;
            this.author = author;
        }
    }
    class BooksStore
    {
        public Book[] bookslist = new Book[5];
        public int BookSize = -1;
        public void Insert()
        {
            Console.Write("Enter Number of book you want to insert : ");
            int NumOfBook = int.Parse(Console.ReadLine());
            if (NumOfBook <= bookslist.Length)
            {
                for (int i = 0; i < NumOfBook; i++)
                {
                    bool IsPresent = false;
                    Console.Write("Enter the Book Id : ");
                    int bid = int.Parse(Console.ReadLine());
                    for (int j = i - 1; j >= 0; j--) //To check book id is already present or not
                    {
                        if (bookslist[j] != null && bookslist[j].bid.Equals(bid))//To avoid null object reference
                        {
                            Console.WriteLine("Please Enter Unique Book Id !! " +
                                    bid + " is already Present");
                            IsPresent = true;
                            NumOfBook++;//To increase the user entered books size
                            break;
                        }
                    }
                    if (!IsPresent)
                    {
                        Console.Write("Enter the Book Name : ");
                        string bname = Console.ReadLine();
                        Console.Write("Enter the Book Price : ");
                        int bprice = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Book Author Id : ");
                        int authorid = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Book Author Name : ");
                        string authorname = Console.ReadLine();
                        bookslist[i] = new Book(bid, bname, bprice, new Author(authorid, authorname));
                    }
                }
                BookSize = NumOfBook;
            }
            else
            {
                Console.WriteLine("Error!! Number of books are more than " + bookslist.Length);
            }
        }
        public void Display(int bookid)
        {
            if (BookSize != -1)
            {
                Console.WriteLine(bookslist.Length + "...........................");
                bool IsDisplay = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == bookid)
                    {
                        Console.WriteLine("Book Details : \nId : " + bookslist[i].bid + "\nName : " + bookslist[i].bname
                                + "\nPrice : " + bookslist[i].bprice + "\nAuthor Id : " + bookslist[i].author.authorId +
                                  "\nAuthor Name : " + bookslist[i].author.authorName);
                        IsDisplay = true;
                    }
                }
                if (!IsDisplay)
                {
                    Console.WriteLine($"{bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\tBookList is empty!!!!...");
                Console.WriteLine("\t\t\t\tFirstly you have to insert the data please select the Insert option ...\n");
            }
        }
        public void Update(int Bookid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == Bookid)
                    {
                        
                    }
                    
                }
                if (result)
                {
                    Console.WriteLine("Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\tBookList is empty!!!!...");
                Console.WriteLine("\t\t\t\tFirstly you have to insert the data please select the Insert option...\n");
            }
        }
        public void Update1(int Bookid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == Bookid)
                    {
                        Console.WriteLine("Enter new Book ID");
                        bookslist[i].bid = int.Parse(Console.ReadLine());
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Book ID Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Update2(int Bookid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == Bookid)
                    {
                        Console.WriteLine("Enter new Book Name");
                        bookslist[i].bname = Console.ReadLine();
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Book Name Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Update3(int Bookid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == Bookid)
                    {
                        Console.WriteLine("Enter new price");
                        bookslist[i].bprice = int.Parse(Console.ReadLine());
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Book Price Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Update4(int Bookid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == Bookid)
                    {
                        Console.WriteLine("Enter new Author ID");
                        bookslist[i].author.authorId = int.Parse(Console.ReadLine());
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Author ID Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Update5(int Bookid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == Bookid)
                    {
                        Console.WriteLine("Enter new Author Name");
                        bookslist[i].author.authorName = Console.ReadLine();
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Author Name Changed Successfully...");
                }
                else
                {
                    Console.WriteLine($"{Bookid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("BookList is empty!!!!...");
                Console.WriteLine("Please Insert data...");
            }
        }
        public void Delete(int bid)
        {
            if (BookSize != -1)
            {
                bool result = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == bid)
                    {
                        result = true;
                        bookslist[i] = null;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine("Delete the data Successfully...");
                }
                else
                {
                    Console.WriteLine("{bid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\tBookList is empty!!!!...");
                Console.WriteLine("\t\t\t\tFirstly you have to insert the data please select the Insert option...\n");
            }
        }
        public void Display_all_Data(int bid)
        {
            if (BookSize != -1)
            {
                Console.WriteLine(bookslist.Length + "...........................");
                bool IsDisplay_all_Data = false;
                for (int i = 0; i < bookslist.Length; i++)
                {
                    if (bookslist[i] != null && bookslist[i].bid == bid)
                    {
                        Console.WriteLine("Book Details : \nId : " + bookslist[i].bid + "\nName : " + bookslist[i].bname
                                + "\nPrice : " + bookslist[i].bprice + "\nAuthor Id : " + bookslist[i].author.authorId +
                                  "\nAuthor Name : " + bookslist[i].author.authorName);
                        IsDisplay_all_Data = true;
                    }
                }
                if (!IsDisplay_all_Data)
                {
                    Console.WriteLine($"{bid} is not Present in current book list");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\tBookList is empty!!!!...");
                Console.WriteLine("\t\t\t\tFirstly you have to insert the data please select the Insert option ...\n");
            }
        }
    }
    class Operation
    {
        static void Main(string[] args)
        {
            BooksStore s = new BooksStore();
            bool ToStop = false;
            do
            {
                Console.WriteLine("\t\t\t\t WELCOME TO CRUD OPERATIONS :");
                Console.WriteLine("\n\t\t\t\tPress 1 To Insert Data\n\t\t\t\tPress 2 To Display Data" +
                    $"\n\t\t\t\tPress 3 To Update Data\n\t\t\t\tPress 4 To Delete Data\n\t\t\t\tPress 5 To Display All Data" +
                    $"\n\t\t\t\tPress 6 To Exit");
                Console.Write("Enter here..");
                int Key = int.Parse(Console.ReadLine());
                switch (Key)
                {
                    case 1:
                        s.Insert();
                        break;
                    case 2:
                        Console.Write("Enter Book's Id : ");
                        s.Display(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Enter Book's Id : ");
                        s.Update(int.Parse(Console.ReadLine()));
                        Console.WriteLine("\n\t\t\t\tPress 1 To Update Book ID\n\t\t\t\tPress 2 To Update Book Name" +
                            $"\n\t\t\t\tPress 3 To Update Book Price\n\t\t\t\tPress 4 To Update Author Id" +
                            $"\n\t\t\t\tPress 5 To Update Author Name");
                        Console.Write("Enter here..");
                        int Number = int.Parse(Console.ReadLine());
                        switch (Number)
                        {
                            case 1:
                                Console.Write("Enter Book's Id : ");
                                s.Update1(int.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                Console.Write("Enter Book's Id : ");
                                s.Update2(int.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                Console.Write("Enter Book's Id : ");
                                s.Update3(int.Parse(Console.ReadLine()));
                                break;
                            case 4:
                                Console.Write("Enter Book's Id : ");
                                s.Update4(int.Parse(Console.ReadLine()));
                                break;
                            case 5:
                                s.Update5(int.Parse(Console.ReadLine()));
                                break;
                            case 6:
                                ToStop = true;
                                break;
                            default:
                                Console.Write("Invalid Key");
                                break;
                        }
                        break;
                    case 4:
                        Console.Write("Enter Book's Id : ");
                        s.Delete(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        s.Display_all_Data(int.Parse(Console.ReadLine()));
                        break;
                    case 6:
                        ToStop = true;
                        break;
                    default:
                        Console.Write("Invalid Key");
                        break;
                }
            } while (!ToStop);
        }
    }
}
