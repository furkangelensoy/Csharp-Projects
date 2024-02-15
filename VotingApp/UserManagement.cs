namespace VotingApp{
    public class UserManagement{
        RegisteredUser registeredUser = new RegisteredUser();

        public bool LogIn(string userName, string passWord){
            bool login = false;
            User user = registeredUser.GetUserName(userName);

            if(user.PassWord == passWord){
                login = true;
                Console.WriteLine("You have succesfully logged in");
                return login;
            }else{
                Console.WriteLine("Incorrect password");
                return login;
            }
        }

        public bool AddUser(User user){
            
            List<User> users = registeredUser.GetUsers();
            int i = 0;
            foreach(User item in users){
                
                if(item.UserName == user.UserName){
                    i++;
                }
            }

            if(i == 0){
                User newUser = new User{
                    Id = users.Count + 1,
                    UserName = user.UserName,
                    PassWord = user.PassWord,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Delete = user.Delete,
                };
                registeredUser.Add(newUser);
                return true;
            }else{
                return false;
            }

        }
    }
}