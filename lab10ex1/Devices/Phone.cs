using lab10ex1.Interfaces;

namespace lab10ex1.Devices
{ 
    class Phone:IContactLessFPayment
    {
        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectueaza plata");
        }

        public void ApropieDispozitiv()
        {
            Console.WriteLine("Apropie telefonul");
        }
    }

   
}
