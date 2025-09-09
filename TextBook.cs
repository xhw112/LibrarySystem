using System;

namespace LibrarySystem
{
    public sealed class TextBook : LibraryItem
    {
        private readonly string publisher;
        public string Publisher => publisher;

        public TextBook(int id, string title, string publisher)
            : base(id, title, ItemType.TextBook)
        {
            this.publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        }

        public override string GetDetails()
            => $"TextBook — Title: {Title}, Publisher: {Publisher}";
    }
}
