using System;
using System.Transactions;

namespace bookStore
{
    class book
    {
        private int _Id;
        private static int _transactions;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
            _transactions=0;
        }


        public book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }
        // GET FUNCTIONS VVVVV
        public string GetFullBook()
        {
            return _Title + " - Written By: " + _Author;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        // SET FUNCTIONS VVVVVVV
        public void SetTrans()
        {
            _transactions++;
        }
        public void SetId(int identification)
        {
            _Id = identification;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {


            book member30 = new book();
            member30.SetId(30);
            member30.SetTitle("Gumball Warrior");
            member30.SetAuthor("Princess Bubblegum");

            book member20 = new book();
            Console.WriteLine("Please enter the book ID: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book name: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            member20.SetAuthor(Console.ReadLine());
            member20.SetTrans();

            book member10 = new book(10, "Shrimp Gumbo", "Bubba Gump");
            member10.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book name: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            book member40 = new book(tempID, tempTitle, tempAuthor);
            member40.SetTrans();
            member30.SetTrans();

            Console.WriteLine();
            Console.WriteLine("The book store has " + member10.GetTrans() + " new books");
            Console.WriteLine("Here's your book information:");
            displayMembers(member10);
            displayMembers(member20);
            displayMembers(member30);
            displayMembers(member40);
        }
        static void displayMembers(book member)
        {
            Console.WriteLine($"Book ID: {member.GetId()}");
            Console.WriteLine($"Book information: {member.GetFullBook()}");
            Console.WriteLine();
        }
    }
}
