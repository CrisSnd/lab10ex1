
using lab10ex1.Interfaces;

namespace lab10ex1.Devices
{
    class SmartWatch:IContactLessFPayment
    {
        public void ApropieDispozitiv()
        {
            Console.WriteLine("Apropiem ceasul");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Platim");
        }
    }
}
