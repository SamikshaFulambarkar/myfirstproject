using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.Mini_Project
{
    /*class Author
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
                        Console.WriteLine("Enter new price");
                        bookslist[i].bprice = int.Parse(Console.ReadLine());
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
    }*/
}
