namespace VotingApp{
    public class RegisteredUser{
        List<User> users;

        public RegisteredUser(){
            users = new List<User>{
                new User {Id = 1, UserName = "noname",PassWord = "pass123",FirstName = "John", LastName = "Nash", Delete = false},
                new User {Id = 2, UserName = "private",PassWord = "word123",FirstName = "Will", LastName = "Smith", Delete = false},
                new User {Id = 3, UserName = "shadow", PassWord = "key123", FirstName = "Julia", LastName = "Royal", Delete = false}
            };
        }

        public void Add(User user){
            users.Add(user);
        }

        public List<User> GetUsers(){
            return users;
        }

        public User GetUserName(string userName){
            return users.Find(u => u.UserName == userName);
        }
    }
}