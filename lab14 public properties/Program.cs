using System;

namespace lab14_public_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new person();
            bob.Name = "bob";
            bob.SetNINO("abs123", "");

        }
    }
    class person
    {
        private string NINO;
        private string password;

        public string Name { get; set; }

        //getter/setter

        public void SetNINO( string newNi, string password)
        {
            if(this.password == password)
            {
                this.NINO = newNi;
            }
        }
    }
}
