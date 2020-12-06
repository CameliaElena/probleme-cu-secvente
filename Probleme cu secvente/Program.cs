using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            //NrPare();
            //PozitivNegativ();
            //SumaProdusul();
            //PozitiaA();
            //elementeEgalPozitie();
            //Crescatoare();
            //MareMic();
            //Fibonacci();
            //Monoton();
            //Invers();
            //GrupuriDeNrConsecutive();
            //MximConsecutive();
            //CrescatoareRotita();
            
            

        }

        
        

            private static void  CrescatoareRotita()
            {
            int n, a, b;
             n = int.Parse(Console.ReadLine());
             a = int.Parse(Console.ReadLine());
            int minim = a;
            bool creste = true;
            int scade = 0;
            for (int i = 0; i < n - 1; i++)
            {
                 b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    creste = false;
                }
                if (a > b && minim > b)
                {
                    scade++;
                }
                a = b;
            }
            if (creste == true || scade == 1)
                Console.WriteLine(" Rotita crescatoare");
            else
                Console.WriteLine("Nu este rotita crescatoare");
            Console.ReadKey();
        }
        
        

        private static void MximConsecutive()
        {
            Console.WriteLine("Introduceti n= ");
            int n = int.Parse(Console.ReadLine());
            int a,b;
            Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int nr = b, max = 1, rez2 = 1, i;

            for (i = 1; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b == nr)
                    max++;
                else
                {
                    if (max > rez2)
                        rez2 = max;
                    max = 1;
                    nr = b;
                }
                if (max > rez2)
                    rez2 = max;
                Console.WriteLine($"Numarul maxim de numere consecutive este  {max}");
                Console.ReadKey();

            }
        }

        //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
        //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        private static void GrupuriDeNrConsecutive()
        {
            
            int n, a, b;
            int i;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a= ");
            a= int.Parse(Console.ReadLine());
            int Secventa = 0;
            bool c = false;
            b = int.Parse(Console.ReadLine());
            a = b;

            for (i = 1; i < n; i++)
            {
                a = b;
                b = int.Parse(Console.ReadLine());

                if (a == 0 && b != 0)
                    c = true;

                if (a != 0 && b == 0 && c == true)
                    Secventa++;

               else if (a > b)
                    c = false;
            }
            if (c == true)
                Secventa++;

            Console.WriteLine($"In secventa sunt {Secventa} grupuri de numere consecutive diferite de zero.");
            Console.ReadKey();
        }

        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa


        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
        private static void Invers()
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int invers;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                invers = 0;
                while (a != 0)
                {
                    invers = invers * 10 + a % 10;
                    a = a / 10;
                }
                s += invers;
            }
            Console.WriteLine(s);
        }

        //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        private static void Monoton()
        {
            int n, a, b;
            int crescator = 0;
            int descrescator = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                b = int.Parse(Console.ReadLine());

                if (a < b)
                    crescator++;
                else
                    descrescator++;
                b = a;
            }
            if (crescator == 0)
                Console.WriteLine("Secventa este monoton descrescatoare");
            else
                if (descrescator == 0)
                Console.WriteLine("Secventa este monoton crescatoare");
            else
                Console.WriteLine("Secventa nu este monotona");
            Console.ReadKey();
        }



        //Determianti al n-lea numar din sirul lui Fibonacci.
        private static void Fibonacci()
        {
            int n, i, a, b, c;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (n == 1 || n == 2)
                Console.WriteLine(1);
            else
            {

                a = 1;
                b = 1;
                for (i = 3; i <= n; ++i)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(c+" ");
            }
            Console.ReadKey();

            }

        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        private static void MareMic()
        {
            int i,  max, min, n, nr;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti nr= ");
            nr = int.Parse(Console.ReadLine());
            max = nr;
            min=nr;
            
            for (i = 1; i < n; i++)
              
            {
                int a= int.Parse(Console.ReadLine());               
                if (a > max)
                max=a;
                
                if (a < min)
                    min = a ;
                
            }
                Console.WriteLine($"Minimul este {min}, iar maximul este {max}");

                Console.ReadKey();
            
           
        }

        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        private static void Crescatoare()
        {
            int n, a, b;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            bool crescator = true;
            Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());



            for (int i = 0; i < n - 1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    crescator = false;
                }
                a = b;
            }
            if (crescator)


                Console.WriteLine("Numerele sunt in ordine crescatoare");

            else
                Console.WriteLine("Numerele nu sunt in ordine crescatoare");
            Console.ReadKey();
        
    }

        //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
        //Se considera ca primul element din secventa este pe pozitia 0. 
        private static void elementeEgalPozitie()
        {
            int n, a;
            int elem = 0;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (a == i)
                    elem++;
                Console.WriteLine(elem);

            }
            Console.ReadKey();

        }

        //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
        //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        private static void PozitiaA()
        {
            int n, e;
            int elem = 0, pozitia = 0;
            Console.WriteLine("n");
             n = int.Parse(Console.ReadLine());
            Console.WriteLine("e");
             e = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == e)
                {
                    elem = 1;
                    pozitia = i+1;
                }
            }
            if (elem == 1)
                Console.WriteLine(pozitia);
            else
                Console.WriteLine(-1);
            Console.ReadKey();


        }

        //Calculati suma si produsul numerelor de la 1 la n. 
        private static void SumaProdusul()
        {
            int a, b, s, p;
                Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b= ");
            b = int.Parse(Console.ReadLine());
            s = 0;
            p = 1;
            s = a + b;
            p = a * b;
            Console.WriteLine("Suma numerelor= "+s);
            Console.WriteLine("Produsul numerelor= "+p);
            Console.ReadKey();



        }

        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        private static void PozitivNegativ()
        {
            int n = int.Parse(Console.ReadLine());
            int x;

            int neg = 0;
            int poz = 0;
            int zero = 0;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x > 0)
                {
                    poz++;
                }

                if (x < 0)
                {
                    neg++;
                }
                if (x == 0)
                {
                    zero++;
                }

            }
            Console.WriteLine($"Ati introdus:{poz} nr pozitive, {neg} numere negative si {zero} nr de zero");
            Console.ReadKey();
        }

        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        private static void NrPare()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele:");
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Elemente pare sunt:");
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                    Console.WriteLine(v[i]);
            }

            Console.ReadLine();

        }
    }
}

