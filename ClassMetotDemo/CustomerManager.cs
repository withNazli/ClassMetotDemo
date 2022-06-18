using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " İsimli Müşteriniz Eklendi.");
        }
        public void Delete(int Id)
        {
            Console.WriteLine(Id + " Id no'lu müşteriniz silindi.");
        }
       
    }
}
