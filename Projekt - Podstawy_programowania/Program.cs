using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region Początek 
            
            //Console.WriteLine("Hejka, Jestem BBot i będe twoim przewodnikiem.");
            //Thread.Sleep(2500);
            //Console.WriteLine("Ale zanim przedstawie ci co będziemy robić, Przedstaw się proszę");
            //Thread.Sleep(1000);
            Console.WriteLine("Chciałbym cie poznać, wystarczy imię");
            string imie = Console.ReadLine();         
            Console.WriteLine("Miło mi cię poznać " + imie + ". To chyba możemy zaczynać.");
            //Thread.Sleep(2000);
            Console.WriteLine("...");
            //Thread.Sleep(2000);
            Console.WriteLine("O kurka Prawie zapomniałem. Jeszcze muszę znać twój wiek");
            //Console.WriteLine("Bez tego nie możemy zacząć");
            int wiek = Convert.ToInt32(Console.ReadLine());

            Osoba Osoba1 = new Osoba();
            Osoba1.name = imie;
            Osoba1.age = wiek;

            człowieczek yes1 = new człowieczek();
            yes1.name = "Wojetk";
            yes1.age = wiek;
            yes1.cos = "cos";
           
            

            if (wiek < 15)
            {
                Console.WriteLine("uuuuuuuuu");
                Console.WriteLine("...");
                Console.WriteLine("No... niestety nie możemy zacząć skoro jesteś nie pełnoletni");
                Console.WriteLine("Nara Lamusie");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (wiek == 15)
            {
                Console.WriteLine("Oki to zaliczasz sie idziemy dalej :D");
                Thread.Sleep(3000);
            }
            else if (wiek < 15)
            {
                Console.WriteLine("Dobrze to Idziemy dalej");
                Console.WriteLine("twój wiek to:" + imie);
                Thread.Sleep(3000);
            }
            Console.WriteLine("to teraz masz do wyboru pare rzeczy");
            #endregion
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            #region Pętla Do-While (Opcje wyboru)
            do
            {
                Console.WriteLine("Proszę wybierz jedną z opcji:");
                Console.WriteLine("1 - Silnia z Wieku     2 - Podstawowe Obliczenia     3 - Lista    4 - Informację o tobie");
                int opcja = Convert.ToInt32(Console.ReadLine());

                if (opcja == 1)
                {
                    try
                    {
                        Console.WriteLine("Wynik to: " + Factorial(wiek));
                    }
                    catch (OutOfMemoryException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O nie Przekroczyłeś pamięć" + e.Message);
                        Console.WriteLine();
                    }
                }
                else if (opcja == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wynik to: " + Dodawanie_odejmowanie(wiek));
                    Console.WriteLine();
                }
                else if(opcja == 3)
                {
                    List<int> Lista = new List<int>();
                    #region Lista
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Wybierz opcję Listy: 1 - dodaj Liczbę     2 - usuń Liczbę     3 - Wyświetl posiadane liczby     4 - Opuść listę");
                        Console.WriteLine();
                        int opcja_lista = Convert.ToInt32(Console.ReadLine());
                        if (opcja_lista == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Podaj cyfrę którą chcesz dodać");
                            Console.WriteLine();
                            int cyfra_lista = Convert.ToInt32(Console.ReadLine());
                            Lista.Add(cyfra_lista);
                        }
                        else if (opcja_lista == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Podaj cyfrę którą chcesz usunąć(Pamiętaj że usuwasz najbliższą czyfrę o twojej wartości)");
                            Console.WriteLine();
                            int cyfra_lista = Convert.ToInt32(Console.ReadLine());
                            Lista.Remove(cyfra_lista);
                        }
                        else if(opcja_lista == 3)
                        {
                            foreach (int n in Lista)
                                Console.WriteLine(n);
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                    #endregion
                }
                else if(opcja == 4)
                {
                    Console.WriteLine();
                    Osoba1.WyswietlOsoba();
                    yes1.WyswietlCZ();
                    Console.WriteLine();
                }

            } while (true);
            #endregion
        }
        
        #region Metody
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Moteda - Silnia
        public static long Factorial(int n)
        {
            long result = 1;

            if (n > 20)
            {
               
                throw new OutOfMemoryException(" Liczba jest zbyt duż by ją zapisać w wartości INT");
            }
            else            
            {
                for (int i = 1; i <= n; i++)
                    result *= i;
            }

            return result;
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Podstawy
        public static double Dodawanie_odejmowanie(double n)
        {
            double Wynik = 1;
            Console.WriteLine("Wybierz jakie działanie chcesz wykonać:    1 - Dodawanie     2 - Odejmowanie     3 - Mnoiżenie    4 - Dzielenie");
            double Opcja = Convert.ToInt32(Console.ReadLine());
            if (Opcja == 1)
            {
                Console.WriteLine("Wpisz jaką cyfre chcesz dodać od wieku");
                double Liczba = Convert.ToDouble(Console.ReadLine());

                double Wynik_dodawania = n + Liczba;
                Wynik *= Wynik_dodawania;
            }

            else if (Opcja == 2)
            {
                Console.WriteLine("Wpisz jaką cyfre chcesz odjąć od wieku");
                double Liczba = Convert.ToDouble(Console.ReadLine());

                double Wynik_odejmowania = n - Liczba;
                Wynik *= Wynik_odejmowania;
            }

            else if (Opcja == 3)
            {
                try
                {
                    Console.WriteLine("Wpisz jaką cyfre chcesz pomnożyć od wieku");
                    double Liczba = Convert.ToDouble(Console.ReadLine());

                    double Wynik_Mnożenia = n * Liczba;
                    Wynik *= Wynik_Mnożenia;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Coś poszło nie tak i nie można Policzyć wyniku");
                    Console.WriteLine("Błąd");
                }
                            
            }
            else if (Opcja == 4)
            {
                Console.WriteLine("Wpisz jaką cyfre chcesz podzielić od wieku");
                double Liczba = Convert.ToDouble(Console.ReadLine());

                double Wynik_Dzielenia = n * Liczba;
                Wynik *= Wynik_Dzielenia;
            }
            
            return Wynik;
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     
        
    }
    #endregion
    class Osoba
    { 
        public int age;
        public string name;
        public void WyswietlOsoba()
        {
            Console.WriteLine("Wiek; {0},  Imie; {1}", age, name);
        }
    }

    class człowieczek : Osoba 
    {
        public string cos;
        public void WyswietlCZ()
        {
            Console.WriteLine("Wiek; {0},  Imie; {1},  Cos: {2}", age, name, cos);
        }
    }
    
}
