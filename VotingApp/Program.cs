namespace VotingApp{
    public class Program
    {
        private static void Main(string[] args)
        {
            UserManagement userManagement = new UserManagement();

            Category[] category = new Category[3];

            category[0] = new Category();
            category[0].Id = 1;
            category[0].Title = "Movie";
            category[0].Vote = 0;

            category[1] = new Category();
            category[1].Id = 2;
            category[1].Title = "Tech Stack";
            category[1].Vote = 0;

            category[2] = new Category();
            category[2].Id = 3;
            category[2].Title = "Sport";
            category[2].Vote = 0;

            bool program = true;

            while(program){
                Console.WriteLine("1- Login\n" + "2- Register\n" + "3- Exit");
                Console.Write("Your choose: ");
                string choose = Console.ReadLine();

                if(choose == "1"){
                    Console.Write("Enter the user name: ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter the password: ");
                    string passWord = Console.ReadLine();

                    bool login = userManagement.LogIn(userName,passWord);

                    if(login){
                        Console.WriteLine("Please vote the categories 1 to 10");

                        foreach(var item in category){
                            Console.Write(item.Id + "- " + item.Title + "= ");
                            int point = int.Parse(Console.ReadLine());
                            item.Vote = point;

                        }

                        Console.WriteLine("************ Result of voting ************");
                        foreach(var item in category){
                            Console.Write(item.Id + "- " + item.Title + "= ");
                            for(int i = 0; i < item.Vote; i++){
                                Console.Write("#");

                            }

                            for(int i = 0; i < 10 - item.Vote; i++){
                                Console.Write("o");

                            }

                            Console.Write(" %" + item.Vote * 10);
                            Console.WriteLine();

                        }

                    }else{

                    }
                }else if(choose == "2"){
                    User user = new User();
                
                    Console.Write("Enter an User Name: ");
                    user.UserName = Console.ReadLine();
                    Console.Write("Enter a password: ");
                    user.PassWord = Console.ReadLine();
                    Console.Write("Enter your firstname: ");
                    user.FirstName = Console.ReadLine();
                    Console.Write("Enter your lastname: ");
                    user.LastName = Console.ReadLine();
                    user.Delete = false;

                    bool register = userManagement.AddUser(user);
                    if(register){
                        Console.WriteLine("Your have successfully registered!");
                    }else{
                        Console.WriteLine("This user name is already using!");
                    }
                }else{
                    program = false;
                }
            }

        }
    }
}
