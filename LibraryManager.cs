using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class LibraryManager
    {
        private readonly List<LibraryItem> catalog = new();
        private readonly List<Member> members = new();

        public void AddItem(LibraryItem item) => catalog.Add(item);
        public void RegisterMember(Member member) => members.Add(member);

        public void ShowCatalog()
        {
            Console.WriteLine("=== Catalog ===");
            foreach (var i in catalog)
            {
                Console.WriteLine($"ID {i.Id}: {i.GetDetails()}");
            }
            Console.WriteLine();
        }

        public LibraryItem? FindItemById(int id) => catalog.Find(i => i.Id == id);
        public Member? FindMemberByName(string name) => members.Find(m => m.Name == name);
    }
}
