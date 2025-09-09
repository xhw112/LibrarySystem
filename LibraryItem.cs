using System;

namespace LibrarySystem
{
    public enum ItemType
    {
        Novels,
        Magazine,
        TextBook
    }

    public abstract class LibraryItem
    {
        private readonly int id;
        private readonly string title;

        public int Id => id;
        public string Title => title;
        public ItemType Type { get; }

        protected LibraryItem(int id, string title, ItemType type)
        {
            this.id = id;
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            Type = type;
        }

        public abstract string GetDetails();
    }
}
