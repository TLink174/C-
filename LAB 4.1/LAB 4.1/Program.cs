// using System;
// using System.Collections;
// using System.Collections.Generic;
//
// interface IBook : IComparable<IBook>
// {
//     string Title { get; set; }
//     string Author { get; set; }
//     string Publisher { get; set; }
//     int Year { get; set; }
//     string ISBN { get; set; }
//     List<string> Chapters { get; set; }
// }
//
// class Book : IBook
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public string Publisher { get; set; }
//     public int Year { get; set; }
//     public string ISBN { get; set; }
//     public List<string> Chapters { get; set; }
//
//     public int CompareTo(IBook other)
//     {
//         if (Publisher != other.Publisher)
//             return Publisher.CompareTo(other.Publisher);
//         if (Author != other.Author)
//             return Author.CompareTo(other.Author);
//         if (Title != other.Title)
//             return Title.CompareTo(other.Title);
//         return Year.CompareTo(other.Year);
//     }
// }
//
// class BookList
// {
//     private List<IBook> books = new List<IBook>();
//
//     public void AddBook(IBook book)
//     {
//         books.Add(book);
//     }
//
//     public void SortBooks(IComparer<IBook> comparer)
//     {
//         books.Sort(comparer);
//     }
//
//     public void PrintBooks()
//     {
//         foreach (var book in books)
//         {
//             Console.WriteLine($"Title: {book.Title}");
//             Console.WriteLine($"Author: {book.Author}");
//             Console.WriteLine($"Publisher: {book.Publisher}");
//             Console.WriteLine($"Year: {book.Year}");
//             Console.WriteLine($"ISBN: {book.ISBN}");
//             Console.WriteLine("Chapters:");
//             foreach (var chapter in book.Chapters)
//             {
//                 Console.WriteLine($"- {chapter}");
//             }
//             Console.WriteLine();
//         }
//     }
// }
//
// class PublisherComparer : IComparer<IBook>
// {
//     public int Compare(IBook x, IBook y)
//     {
//         if (x.Publisher != y.Publisher)
//             return x.Publisher.CompareTo(y.Publisher);
//         if (x.Author != y.Author)
//             return x.Author.CompareTo(y.Author);
//         if (x.Title != y.Title)
//             return x.Title.CompareTo(y.Title);
//         return x.Year.CompareTo(y.Year);
//     }
// }
// class AuthorComparer : IComparer<IBook>
// {
//     public int Compare(IBook x, IBook y)
//     {
//         if (x.Author != y.Author)
//             return x.Author.CompareTo(y.Author);
//         if (x.Title != y.Title)
//             return x.Title.CompareTo(y.Title);
//         return x.Year.CompareTo(y.Year);
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         BookList bookList = new BookList();
//
//         bookList.AddBook(new Book
//         {
//             Title = "Book A",
//             Author = "Author C",
//             Publisher = "Publisher A",
//             Year = 2020,
//             ISBN = "ISBN A",
//             Chapters = new List<string> { "Chapter 1", "Chapter 2" }
//         });
//
//         bookList.AddBook(new Book
//         {
//             Title = "Book B",
//             Author = "Author A",
//             Publisher = "Publisher B",
//             Year = 2018,
//             ISBN = "ISBN B",
//             Chapters = new List<string> { "Chapter 1", "Chapter 2", "Chapter 3" }
//         });
//
//         bookList.AddBook(new Book
//         {
//             Title = "Book C",
//             Author = "Author B",
//             Publisher = "Publisher C",
//             Year = 2019,
//             ISBN = "ISBN C",
//             Chapters = new List<string> { "Chapter 1" }
//         });
//
//         Console.WriteLine("Unsorted list of books:");
//         bookList.PrintBooks();
//         
//         bookList.SortBooks(new AuthorComparer());
//         Console.WriteLine("\n Sorted list of books by Author");
//         bookList.PrintBooks();
//
//         bookList.SortBooks(new PublisherComparer());
//         Console.WriteLine("\nSorted list of books by Publisher:");
//         bookList.PrintBooks();
//     }
// }
using System;
using System.Collections.Generic;
using System.IO;

class Account
{
    public int AccountID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Balance { get; set; }

    public Account(int id, string firstName, string lastName, double balance)
    {
        AccountID = id;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

    public void FillInfo()
    {
        Console.WriteLine("Enter Account ID:");
        AccountID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter First Name:");
        FirstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name:");
        LastName = Console.ReadLine();
        Console.WriteLine("Enter Balance:");
        Balance = Convert.ToDouble(Console.ReadLine());
    }

    public void Query()
    {
        Console.WriteLine($"Account ID: {AccountID}, Name: {FirstName} {LastName}, Balance: {Balance}");
    }

    public override string ToString()
    {
        return $"{AccountID},{FirstName},{LastName},{Balance}";
    }

    public static Account Parse(string line)
    {
        string[] parts = line.Split(',');
        return new Account(Convert.ToInt32(parts[0]), parts[1], parts[2], Convert.ToDouble(parts[3]));
    }
}

class AccountList
{
    private List<Account> accounts = new List<Account>();

    public void NewAccount()
    {
        Account account = new Account(0, "", "", 0);
        account.FillInfo();
        accounts.Add(account);
    }

    public void SaveFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Account acc in accounts)
                {
                    writer.WriteLine(acc.ToString());
                }
            }
            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving data: " + ex.Message);
        }
    }

    public void LoadFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    accounts.Add(Account.Parse(line));
                }
            }
            Console.WriteLine("Data loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading data: " + ex.Message);
        }
    }

    public void Report()
    {
        foreach (Account acc in accounts)
        {
            acc.Query();
        }
    }

    public void RemoveAccount(int accountID)
    {
        Account accToRemove = accounts.Find(acc => acc.AccountID == accountID);
        if (accToRemove != null)
        {
            accounts.Remove(accToRemove);
            Console.WriteLine("Account removed successfully.");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void SortByID()
    {
        accounts.Sort((x, y) => x.AccountID.CompareTo(y.AccountID));
    }

    public void SortByName()
    {
        accounts.Sort((x, y) => string.Compare(x.FirstName + x.LastName, y.FirstName + y.LastName));
    }

    public void SortByBalance()
    {
        accounts.Sort((x, y) => x.Balance.CompareTo(y.Balance));
    }
}

class Program
{
    static void Main(string[] args)
    {
        AccountList accountList = new AccountList();
        string fileName;

        while (true)
        {
            Console.WriteLine("\nEnter command: (Add, Save, Load, Report, Remove, SortByID, SortByName, SortByBalance, Exit)");
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "add":
                    accountList.NewAccount();
                    break;
                case "save":
                    Console.WriteLine("Enter file name to save:");
                    fileName = Console.ReadLine();
                    accountList.SaveFile(fileName);
                    break;
                case "load":
                    Console.WriteLine("Enter file name to load:");
                    fileName = Console.ReadLine();
                    accountList.LoadFile(fileName);
                    break;
                case "report":
                    accountList.Report();
                    break;
                case "remove":
                    Console.WriteLine("Enter Account ID to remove:");
                    int idToRemove = Convert.ToInt32(Console.ReadLine());
                    accountList.RemoveAccount(idToRemove);
                    break;
                case "sortbyid":
                    accountList.SortByID();
                    Console.WriteLine("Sorted by Account ID.");
                    break;
                case "sortbyname":
                    accountList.SortByName();
                    Console.WriteLine("Sorted by Name.");
                    break;
                case "sortbybalance":
                    accountList.SortByBalance();
                    Console.WriteLine("Sorted by Balance.");
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}

