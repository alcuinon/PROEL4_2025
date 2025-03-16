namespace RazorPagesUI.Model
{
    public class ContestantScore
    {
        public string Id { get; set; }
        public string ContestantId { get; set; }
        public int Score { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Contestant Contestant { get; set; }
    }
}
