// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

class Program
{
    static void Main(string[] args)
    {

        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.Name = "Nazlı";
        customer1.LastName = "Çorak";


        Customer customer2 = new Customer();
        customer2.Id = 2;
        customer2.Name = "Engin";
        customer2.LastName = "Demiroğ";



        
        CustomerManager customerManager = new CustomerManager();

        customerManager.Add(customer1);
        customerManager.Delete(2);
      
    }
}
