
namespace lab10ex1.Devices
{
     class PosWithoutInterfaces
    {
        public void Plateste(Card card)
        {
            card.IntroduCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();
        }

        public void PlatesteContactLess(Phone phone)
        {
            phone.ApropieDispozitiv();
            phone.EfectueazaPlata();
        }

        public void PlatesteContactLess(CardContactLess cardContactLess)
        {
            cardContactLess.ApropieDispozitiv();
            cardContactLess.EfectueazaPlata();
        }

        public void PlatesteContactLess(SmartWatch cardContactLess)
        {
            cardContactLess.ApropieDispozitiv();
            cardContactLess.EfectueazaPlata();
        }
    }
}
