namespace BankApp
{
    // step 1: Create a class as Customer_Account
    // internal access modifier used for class because I won't need this class in other assembly.
    internal class Customer_Account
    {
        // step 2: Declare 3 variables string bank_name, long customer_accountNo, String customer_name;
        public static string bank_name; // public static varible so that we can use it without instance creation from anywhere and can initialize only once(because bank name always going to be same, so there is no use of assigning separate memory for every instance)
        private readonly long customer_accountNo; // private variable so that it can not be accessible to instance, readonly so it can be assigned only once per instance and can not be changed after that
        private readonly string customer_name;

        // step 3: Create a parameterized constructor that takes 2 parameters accountNo and customerName and initialize the member of the class
        public Customer_Account(long accountNo, string customerName)
        {
            customer_accountNo = accountNo;
            customer_name = customerName;
        }

        // step 4: Create a method as void printInfo() that prints all the member of the Customer_Account
        // purpose - to print the data of specific instance
        // internal(access modifier) - I won't be having any use of this method in other assembly
        // void(return type) - method is used for printing data only
        internal void PrintInfo()
        {
            Console.WriteLine(
                $"\nBank Name: {bank_name}" +
                $"\n\tAccount Number: {customer_accountNo}" +
                $"\n\tCustomer Name: {customer_name}"
                );
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ABC Bank's App");
            // step 5: Define the Customer_Account in the main method
            Customer_Account Account1 = new(1234567890, "Customer Name 1");
            // step 6: Initialize the bank_name
            Customer_Account.bank_name = "ABC Bank";
            // step 7: Call printInfo() and display the output
            Account1.PrintInfo();
        }
    }
}