

namespace GTKChatBot.Bot
{
    public class UserProfile
    {
        public string Name { get; set; }

        public int NumberofPeople { get; set; }

        // The list of companies the user wants to review.
        public List<string> CompaniesToReview { get; set; } = new List<string>();
    }
}
