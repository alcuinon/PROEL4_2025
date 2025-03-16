using RazorPagesUI.Model;

namespace RazorPagesUI.Database
{
    public static class MyDatabase
    {
        public static List<Contestant> Contestants { get; set; } = new List<Contestant>();
        public static List<ContestantScore> ContestantScores { get; set; } = new List<ContestantScore>();
    }
}
