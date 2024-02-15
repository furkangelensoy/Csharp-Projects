namespace VotingApp{
    public class Category{
        private int id;
        private string title;
        private int vote;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Vote { get => vote; set => vote = value; }
    }
}