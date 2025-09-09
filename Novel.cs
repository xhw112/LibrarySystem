using System;

namespace LibrarySystem
{
    public sealed class Novel : LibraryItem
    {
        private readonly string author;
        public string Author => author;

        public Novel(int id, string title, string author)
            : base(id, title, ItemType.Novels)
        {
            this.author = author ?? throw new ArgumentNullException(nameof(author));
        }

        public override string GetDetails()
            => $"Novel — Title: {Title}, Author: {Author}";
    }
}
