 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkieletGrA
{
    class Program
    {
        static void Main()
        {
        }
    }
    interface IStudent
    {
        string Imie { get; }
        string Nazwisko { get; }

        double[] OcenyZPrzedmiotow { get; }     /** Tablica zawierająca oceny ze wszystkich przedmiotów studenta*/

        /*Funkcja wyświetlająca informacje o studencie  
            -Imie 
            -Nazwisko
            -średnią ocene
         */
        void InfoOStudencie();


        /*Funkcja ma obliczać średnią ocenę
         @return srednia ocena
         */
        double ObliczSredniaOcene();
    }

    interface IWykladowca
    {
        string Imie { get; }
        string Nazwisko { get; }
        string DataZatrudnienia { get; }     /** Zamieniane na datetime w metodzie ObliczStaz**/

        void InfoWykladowca(); // ma wyświetlać imię, nazwisko i datę zatrudnienia
        int ObliczStaz(); // ma wyświetlać staz w dniach, uzywajac obecnego czasu systemowego
    }

    interface IDziekanat
    {
        string NazwaUczelni { get; }
        string Ulica { get; }
        string Miasto { get; }
        double PieniadzeZaStudenta { get; }
        int LiczbaStudentow { get; }

        void WyswietlInformacje(); //metoda wyswietlajaca nazwe i adres uczelni(miasto i ulica)
        double ObliczDotacjeZaStudentow(); //metoda ma obliczać wielkosc dotacji na podstawie zmiennych PieniadzeZaStudenta i LiczbaStudentow

    }
}
