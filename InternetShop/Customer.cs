using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Customer: IComparable<Customer>
    {
        public int Id { get; set; }
        private string Name;
        private string PhoneNumber;

        public Customer(string name, string phoneNumber)
        {
            Id = 0;
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public string GetName() { return Name; }
        public string GetPhoneNumber() { return PhoneNumber; }
        public void SetName(string name) { Name = name; }
        public void SetPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; }
        public void ShowCustomer()
        {
            Console.WriteLine("ID: {0}\t Name: {1}\t Phone number: {2}", Id, Name, PhoneNumber);
        }

        public int CompareTo(Customer? other)
        {
            if (Id < other?.Id) return -1;
            if (Id > other?.Id) return 1;
            return 0;
        }
    }
}
