using System.Data.Common;

namespace AtmApp{
    public class Log{
        
        public void writeLog(int id, string logMessage){
            string folderPath = @"D:\.NetPractice\Csharp-Projects\AtmApp\CustomerLogs";
            string[] logFiles = Directory.GetFiles(folderPath, id + ".txt");

            if(logFiles.Length == 0){
                Console.WriteLine($"No customer was found for the entered {id} id number ");
                return;
            }

            string logFilePath = logFiles[0];

            using (StreamWriter logWriter = File.AppendText(logFilePath)){
                logWriter.WriteLine(logMessage);
            }
        }

        public void checkFolderPath(){
            string folderPath = @"D:\.NetPractice\Csharp-Projects\AtmApp\CustomerLogs";
            if(!Directory.Exists(folderPath)){
                Directory.CreateDirectory(folderPath);

                foreach(Customer customer in DefaultCustomers.customers){
                    string logFilePath = Path.Combine(folderPath, customer.Id + ".txt");

                    if(!File.Exists(logFilePath)){
                        File.Create(logFilePath);
                    }
                }
            }else{
                foreach(Customer customer in DefaultCustomers.customers){
                    string logFilePath = Path.Combine(folderPath, customer.Id + ".txt");

                    if(!File.Exists(logFilePath)){
                        File.Create(logFilePath);
                    }
                }
            }
        }
        
        public void CorrectLogin(string name, int id){
            string logMessage = $"{name} with id number {id} successfully logged in on {DateTime.Now}!";
            writeLog(id,logMessage);
        }


        public void failedLogin(string name, int id){
            string logMessage = $"{name} with id number {id} failed log in on {DateTime.Now}!";
            writeLog(id, logMessage);
        }

        public void CorrectWithdrawal(string name, int id, int amount){
            string logMessage = $"{name} with id number {id} successfully withdrawal {amount}$ on {DateTime.Now}!";
            writeLog(id,logMessage);
        }

        public void FailedWithdraw(string name, int id, int amount){
            string logMessage = $"{name} with id number {id} failed withdrawal {amount}$ on {DateTime.Now}!";
            writeLog(id,logMessage);
        }

        public void CorrectDeposit(string name, int id, int amount){
            string logMessage = $"{name} with id number {id} successfully deposit {amount}$ on {DateTime.Now}!";
            writeLog(id,logMessage);
        }
        
        public void FailedDeposit(string name, int id, int amount){
            string logMessage = $"{name} with id number {id} failed deposit {amount}$ on {DateTime.Now}!";
            writeLog(id,logMessage);
        }

        public void CorrectSendMoney(string senderName, int senderId, int amount, string receiverName, int receiverId){
            string logMessage = $"{senderName} with id number {senderId} successfully sent {amount}$ to {receiverName} with id number {receiverId} on {DateTime.Now}!";
            writeLog(senderId, logMessage);
        }
        
        public void FailedSendMoney(string senderName, int senderId, int amount, string receiverName, int receiverId){
            string logMessage = $"{senderName} with id number {senderId} failed send {amount}$ to {receiverName} with id number {receiverId} on {DateTime.Now}!";
            writeLog(senderId,logMessage);
        }

        public void CorrectTakeMoney(string senderName, int senderId, int amount, string receiverName, int receiverId){
            string logMessage = $"{receiverName} with id number {receiverId} successfully received {amount}$ from {senderName} with id number {senderId} on {DateTime.Now}!";
            writeLog(receiverId,logMessage);
        }

        public void ViewBalance(string name, int id){
            string logMessage = $"{name} with id number {id} viewed his/her balance on {DateTime.Now}!";
            writeLog(id,logMessage);
        }

        public void LogOut(string name, int id){
            string logMessage = $"{name} with id number {id} logged out on {DateTime.Now}!";
            writeLog(id,logMessage);
        }

    }
}