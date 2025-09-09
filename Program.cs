using System;

namespace LibrarySystem
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var library = new LibraryManager();

            library.AddItem(new Novel(1, "A", "a"));
            library.AddItem(new Magazine(2, "B", 101));
            library.AddItem(new TextBook(3, "C", "c"));

            var alice = new Member("alice");
            var bob   = new Member("bob");

            library.RegisterMember(alice); 
            library.RegisterMember(bob);

            library.ShowCatalog();

            var item = library.FindItemById(1);
            if (item != null) alice.BorrowItem(item);

            item = library.FindItemById(2);
            if (item != null) alice.BorrowItem(item);

            item = library.FindItemById(3);
            if (item != null) alice.BorrowItem(item);

            item = new Novel(4, "D", "d");
            library.AddItem(item);

            alice.BorrowItem(item);  
            Console.WriteLine("\nAlice currently has:");
            foreach (var bi in alice.GetBorrowedItems())
                Console.WriteLine($"- {bi.Title} ({bi.Type})");

            Console.WriteLine("\nDone.");
        }
    }
}
