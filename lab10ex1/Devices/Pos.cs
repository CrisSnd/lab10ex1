

using lab10ex1.Interfaces;

namespace lab10ex1.Devices
{
     class Pos
    {
        public void Plateste(IContactLessFPayment card)
        {
            card.ApropieDispozitiv();
            card.EfectueazaPlata();
        }

        public void Plateste(IContactFullPayment card)
        {
            card.IntroduCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();
        }
    }
}
