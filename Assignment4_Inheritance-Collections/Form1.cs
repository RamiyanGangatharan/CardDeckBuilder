namespace Assignment4_Inheritance_Collections
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void CreateCustomCardButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int suit = random.Next(0, 4);
            int rank = random.Next(0, 13);

            PlayingCard card = new PlayingCard(suit, rank, false);
            RankRTB.Text = card.GetRankString();
            SuitRTB.Text = card.GetSuitString();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e) { Close(); }
    }
}