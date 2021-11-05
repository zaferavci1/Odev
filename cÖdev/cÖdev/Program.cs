using System;



namespace enginDemiroğ
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.FirstName = "Musa";
            customer.LastName = "   Uyumaz";
            Kayit(customer);
            Duzenle(customer);

        }
        static void Kayit(Customer customer)
        {
            Console.WriteLine(customer.FirstName + customer.LastName + "  Kullanıcı sisteme eklendi!");
        }
        static void Duzenle(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "  Kullanıcının kaydı düzenlendi!");
        }

    }
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }



}