using System.Reflection.Metadata;

namespace AtmApp{
    public class AtmOperation{
        static Log log = new Log();
        static Customer loggedCustomer;
        
        public void run(){
            bool program = true;

            while(program){
                log.checkFolderPath();

                userInformation:
                Console.WriteLine("Welcom to AtmApp! Please enter your information.");
                Console.Write("Enter your id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter your password: ");
                string passWord = Console.ReadLine();

                loggedCustomer = findLoggedCustomer(id,passWord);

                if(loggedCustomer != null){
                    bool operation = true;
                    while(operation){
                        Console.WriteLine("******* Welcome " + loggedCustomer.Name + " " + loggedCustomer.LastName + " *******\n" + "Select the action you want to do: ");
                        Console.WriteLine("1- Withdraw Money\n" + "2- Deposit Money\n" + "3- Transfering Money\n" + "4- View Balance\n" + "5- Exit");
                        Console.Write("Your choose: ");
                        int choose = int.Parse(Console.ReadLine());

                        switch(choose){
                            case 1:
                                withDraw();
                                break;
                            case 2:
                                deposit();
                                break;
                            case 3:
                                sendMoney();
                                break;
                            case 4:
                                viewBalance();
                                break;
                            case 5:
                                log.LogOut(loggedCustomer.Name,loggedCustomer.Id);
                                operation = false;
                                break;
                        }
                    }
                }
                
            }
        }


        public Customer findLoggedCustomer(int id, string passWord){
            var loggedCustomer = DefaultCustomers.customers.FirstOrDefault(f => f.Id == id && f.PassWord == passWord);
            if(loggedCustomer != null){
                log.CorrectLogin(loggedCustomer.Name, loggedCustomer.Id);
                return loggedCustomer;
            }else{
                var customerExists = DefaultCustomers.customers.Any(f => f.Id == id);
                if(customerExists){
                    Console.WriteLine("You have logged in incorrectly");
                    loggedCustomer = DefaultCustomers.customers.FirstOrDefault(f => f.Id == id);
                    log.failedLogin(loggedCustomer.Name,loggedCustomer.Id);
                }else{
                    Console.WriteLine("User not found!");
                }
            }
            return null;
        }

        public void withDraw(){
            Console.Write("Please enter the amount of money you want to withdraw: ");
            int amount = int.Parse(Console.ReadLine());

            if(loggedCustomer.Balance > amount){
                loggedCustomer.Balance = loggedCustomer.Balance - amount;
                Console.WriteLine("Withdrawal was successful, new balance: " + loggedCustomer.Balance);
                log.CorrectWithdrawal(loggedCustomer.Name,loggedCustomer.Id,amount);
            }else{
                Console.WriteLine("Insufficient balance!");
                log.FailedWithdraw(loggedCustomer.Name,loggedCustomer.Id,amount);
            }
        }

        public void deposit(){
            Console.Write("Please enter the amount of money you want to deposit: ");
            int amount = int.Parse(Console.ReadLine());

            loggedCustomer.Balance = loggedCustomer.Balance + amount;
            Console.WriteLine("Deposit was successful, new balance: " + loggedCustomer.Balance);
            log.CorrectDeposit(loggedCustomer.Name,loggedCustomer.Id,amount);

        }

        public void sendMoney(){
            Console.WriteLine("Please enter the name of the person you want to transfer money!");
            Console.Write("Receiver name: ");
            string receiverName = Console.ReadLine();
            Console.WriteLine("Please enter the id of the person you want to transfer money!");
            Console.Write("Receiver Id: ");
            int receiverId = int.Parse(Console.ReadLine());
            Customer receiverPerson = DefaultCustomers.customers.Find(f => f.Id == receiverId && f.Name == receiverName);
            if(receiverPerson != null){
                Console.Write("Please enter the amount: ");
                int amount = int.Parse(Console.ReadLine());
                
                if(loggedCustomer.Balance > amount){
                    loggedCustomer.Balance = loggedCustomer.Balance - amount;
                    receiverPerson.Balance = receiverPerson.Balance + amount;
                    Console.WriteLine("Money transfer was successful, current balance: " + loggedCustomer.Balance);
                    log.CorrectSendMoney(loggedCustomer.Name,loggedCustomer.Id,amount,receiverPerson.Name,receiverPerson.Id);
                    log.CorrectTakeMoney(loggedCustomer.Name,loggedCustomer.Id,amount,receiverPerson.Name,receiverPerson.Id);

                }else{
                    Console.WriteLine("Insufficient balance!");
                    log.FailedSendMoney(loggedCustomer.Name,loggedCustomer.Id,amount,receiverPerson.Name,receiverPerson.Id);
                }
            }
        }

        public void viewBalance(){
            Console.WriteLine("Current Balance: " + loggedCustomer.Balance);
            log.ViewBalance(loggedCustomer.Name,loggedCustomer.Id);
        }
    }
}