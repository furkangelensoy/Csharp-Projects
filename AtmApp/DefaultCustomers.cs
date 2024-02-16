namespace AtmApp{
    public static class DefaultCustomers{
        public static List<Customer> customers = new List<Customer>();
        static DefaultCustomers(){
            customers.Add(new Customer("John","Smith",1703,"123",1000));
            customers.Add(new Customer("Noah","Wilson",1704,"321",1000));
            customers.Add(new Customer("Julia","Royal",1705,"asd",1000));
            customers.Add(new Customer("Charlotte","Anderson",1706,"dsa",1000));
            customers.Add(new Customer("Cameron","Green",1707,"qwe",1000));
        }
    }
}