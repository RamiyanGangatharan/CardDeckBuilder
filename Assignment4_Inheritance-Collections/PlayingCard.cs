namespace Assignment4_Inheritance_Collections
{
    internal class PlayingCard
    {
        protected int suit;
        protected int rank;
        protected bool faceUp; // True == Visible, False == Invisible

        static private string[] suits =
            {
                "Hearts", "Clubs", "Diamonds", "Spades"
            };
        static private string[] ranks =
            {
                "Ace", "Two", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"
            };

        // Default Constructor
        public PlayingCard()
        {
            // Default is facedown ace of hearts.
            suit = 0;
            rank = 0;
            faceUp = false;
        }

        // Parameterized Constructor 
        public PlayingCard(int suit, int rank, bool faceUp)
        {
            ValidateSuitInt(suit);
            ValidateRankInt(rank);
            this.faceUp = faceUp;
        }

        // Pick a card, any card!
        public PlayingCard(int pick)
        {
            Random randomValue = new Random();

            // Creates a value within those set parameters
            this.suit = randomValue.Next(0, 3);
            this.rank = randomValue.Next(0, 12);
            this.faceUp = false;
        }

        // Accessors
        public int GetSuitInt() { return suit; }
        public string GetSuitString() { return suits[suit]; }
        public int GetRankInt() { return rank; }
        public string GetRankString() { return ranks[rank]; }
        public bool GetFaceUp() { return faceUp; }
        public int GetStandardDeckIndex() { return (suit * 13) + rank; }
        public void SetSuitInt(int newSuit) { ValidateSuitInt(newSuit); }
        public void SetRankInt(int newRank) { ValidateRankInt(newRank); }
        private void ValidateSuitInt(int newSuit)
        {
            if (newSuit > -1 && newSuit < 4) { suit = newSuit; }
            else { throw new ArgumentException("Suit must be between 0 and 3"); }
        }

        private void ValidateRankInt(int newRank)
        {
            if (newRank > -1 && newRank < 13) { rank = newRank; }
            else { throw new ArgumentException("Rank must be between 0 and 12"); }
        }
    }
}
