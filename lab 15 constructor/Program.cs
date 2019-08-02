using System;

namespace lab_15_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person("hg8560f", "password", "bob");
            var peter = new Person("bb5060g", "password1", "peter");

            peter.GetNINO("hfhfjfkdk", "password1");
        }
    }
    class Person
    {
        private string NINO;
        private string password;
        public string Name;

        public Person(string NINO, string password, string Name)
        {
            this.NINO = NINO;
            this.password = password;
            this.Name = Name;

            
        }
        public bool SetNINO(string newNINO, string newPassword)
        {
            bool itworks = false;

            if(this.password == newPassword)
            {
                this.NINO = newNINO;
            }
            Console.WriteLine(itworks.ToString());
            return itworks;
        }
        public void GetNINO(string newNINO, string newPassword)
        {
          

            if (this.password == newPassword)
            {
                
                Console.WriteLine(this.NINO.ToString());
            }
          
            
        }
    }
}
