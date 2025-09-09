namespace LibrarySystem
{
    public sealed class Magazine : LibraryItem
    {
        private readonly int issueNumber;
        public int IssueNumber => issueNumber;

        public Magazine(int id, string title, int issueNumber)
            : base(id, title, ItemType.Magazine)
        {
            this.issueNumber = issueNumber;
        }

        public override string GetDetails()
            => $"Magazine — Title: {Title}, Issue: {IssueNumber}";
    }
}
