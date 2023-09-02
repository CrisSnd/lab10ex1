
using lab10ex1.Interfaces;

namespace lab10ex1.Devices
{
    class Card : IContactFullPayment
    {
        public void IntroduCardul()
        {
            Console.WriteLine("Introducere Card");
        }

        public void ExtrageCardul()
        {
            Console.WriteLine("Extragere card");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectueaza plata"); 
        }
    }
}