using lab10ex1.Devices;
using System;


namespace lab10ex1
{
     class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti un program care va modela operatiunile unei casa de marcat.
            Casa de marcat
            O casa de marcat va avea o metoda prin care va scana un produs, va oferi metode de plata cash sau prin
            intermediul unui POS.
            • In cazul platii cash, casa de marcat
            1. va deschide un seif
            2. va introduce suma in seif
            3. va inchide seif-ul
            4. Va elibera chitanta
            Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma
            de plata. La fiecare dintre operatiunile de mai sus, un mesaj corespunzator va fi afisat pe ecran
            • In cazul platii cu cardul, casa de marcat va pune la dispozitia clientului un POS, printr-o metoda care
            va oferi la cerere un POS
            POS-ul
            POS-ul va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi
            modelate prin intermediul a doua metode, ce vor primi doi parametri: suma si dispozitivul prin care se
            va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata.
            Pentru plata prin intermediul POS-ului, clientul va putea folosi atat
            carduri clasice – suporta doar plati contactfull
             carduri contactless - suporta atat plati contact-full cat si plati contactless
             telefoane mobile contactless - suporta doar plati contactless
            Descrierea interfetelor
            Plata contact-full implica urmatoarele operatiuni:
             IntroduCard
             EfectueazaPlata
             ExtrageCard
            Plata contactless implica urmatoarele operatiuni:
             ApropieCard
             EfectueazaPlata
            Instantiati casa, carduri, telefoane, efectuati plati.


            Suplimentar
            Scrieti un program care va modela operatiunile unei casa de marcat.
            Casa de marcat
            O casa de marcat va avea o metoda prin care va scana un produs, va oferi metode de plata cash sau prin
            intermediul unui POS.
            • In cazul platii cash, casa de marcat
            1. va deschide un seif
            2. va introduce suma in seif
            3. va inchide seif-ul
            4. Va elibera chitanta
            Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma
            de plata. La fiecare dintre operatiunile de mai sus, un mesaj corespunzator va fi afisat pe ecran
            • In cazul platii cu cardul, casa de marcat va pune la dispozitia clientului un POS, printr-o metoda care
            va oferi la cerere un POS
            La finalizarea unei plati cash, casa va putea pune la dispozitie, prin intermediul unei
            proprietati, un bon de casa, pe care va fi mentionata suma platita.
            POS-ul
            POS-ul va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi
            modelate prin intermediul a doua metode, ce vor primi doi parametri: suma si dispozitivul prin care se
            va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata. 
             La finalizarea unei plati POS, acesta va putea pune la dispozitie, prin intermediul unei
            proprietati, un bon POS pe care va fi mentionata suma si metoda de plata, iar casa de marcat
            va pune la dispozitie bonul de casa.
            Pentru plata prin intermediul POS-ului, clientul va putea folosi atat
             carduri clasice – suporta doar plati contactfull
             carduri contactless - suporta atat plati contact-full cat si plati contactless
             telefoane mobile contactless - suporta doar plati contactless
            Descrierea interfetelor
            Plata contact-full implica urmatoarele operatiuni:
             IntroduCard
             EfectueazaPlata
             ExtrageCard
            Plata contactless implica urmatoarele operatiuni:
             ApropieCard
             EfectueazaPlata
            Bonul de casa va contine o metoda care va returna descrierea acestuia precum si o metoda de
             extensie prin care descrierea va fi tiparita pe consola.
             Instantiati casa, carduri, telefoane, efectuati plati, afisati bonurile.
             */

           ;


            Card card=new Card();
            Phone phone=new Phone();
            CardContactLess cardContactLess=new CardContactLess();
            SmartWatch smartWatch=new SmartWatch();

            Pos pos = new Pos();
            pos.Plateste(card);
            pos.Plateste(phone);

            PosWithoutInterfaces posWithoutInterfaces=new PosWithoutInterfaces();
        }



    }



}
