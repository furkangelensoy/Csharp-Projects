namespace AtmApp{
    public class Customer{
        private string name;
        private string lastName;
        private int ıd;
        private string passWord;
        private int balance;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => ıd; set => ıd = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Balance { get => balance; set => balance = value; }

        public Customer(string name, string lastName, int ıd, string passWord, int balance)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = ıd;
            this.PassWord = passWord;
            this.Balance = balance;
        }

       
    }
}