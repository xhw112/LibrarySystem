using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Member
    {
        private readonly string name;
        public string Name => name;

        private readonly List<LibraryItem> borrowedItems = new();

        public Member(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void BorrowItem(LibraryItem item)
        {
            if (borrowedItems.Count >= 3)
            {
                Console.WriteLine("You cannot borrow more than 3 items.");
                return;
            }

            borrowedItems.Add(item);
            Console.WriteLine($"{Name} borrowed '{item.Title}'.");
        }

        public void RetrunItems(LibraryItem item)
        {
            if (borrowedItems.Contains(item))
            {
                borrowedItems.Remove(item);
                Console.WriteLine($"'{item.Title}' has been successfully returned by {Name}.");
            }
            else
            {
                Console.WriteLine($"'{item.Title}' was not in the list of borrowed items.");
            }
        }

        public void ReturnItem(LibraryItem item) => RetrunItems(item);

        public List<LibraryItem> GetBorrowedItems() => borrowedItems;
    }
}
