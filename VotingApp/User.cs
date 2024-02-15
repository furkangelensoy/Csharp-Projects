namespace VotingApp{
    public class User{
        private int id;
        private string userName;
        private string passWord;
        private string firstName;
        private string lastName;
        private bool delete;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public bool Delete { get => delete; set => delete = value; }
    }
}