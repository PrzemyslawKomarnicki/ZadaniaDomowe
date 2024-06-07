using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaDomowe
{
    public class ZadaniaMetody
    {
        public void TypyDanychZadanie1()
        {
            //            Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane
            //które chcesz przetrzymywać to:
            //a.Imię,
            //b.Nazwisko
            //c.Wiek
            //d.Płeć (‘m’ albo ‘k’)
            //e.PESEL
            //f.Numer pracownika (np. 2509324094)
            //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

            string name = "Przemek";
            string surname = "Komarnicki";
            int age = 33;
            char gender = 'm';
            string pesel = "91121203456";
            long idNumber = 2509324094;
        }
        public void TypyDanychZadanie2()
        {

        //            2.Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
        //odwrotnej kolejności niż zostały zadeklarowane.

            char field1 = 'a';
            char field2 = 'b';
            char field3 = 'c';

            Console.WriteLine($"{field3} {field2} {field1}");
                
        }
        public void TypyDanychZadanie3()
        {
        //            3.Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
        //przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

            Console.WriteLine("Please enter first side of rectangle");
            int sideA;
            Int32.TryParse(Console.ReadLine(), out sideA);
            Console.WriteLine("Please ented second side of rectangle");
            int sideB;
            Int32.TryParse(Console.ReadLine(), out sideB);

            double diagonal2 = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            double diagonal = Math.Pow(diagonal2, 0.5);
            Console.WriteLine($"The diagonal of rectangle = {diagonal}");
        }
        public void TypyDanychZadanie4()
        {
        //            4.Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
        //przypiszesz im następujące wartości:
        //            a. 10
        //b.Szkoła Dotneta
        //c. 12,5
        //Pamiętaj o użyciu poprawnych typów danych.

            int number = 10;
            string write = "Szkoła Dotneta";
            double number2 = 12.5;
        }
        public void TypyDanychZadanie5()
        {
            //            5.Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
            //numer telefonu, adres email, wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej)
            //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
            //typDanych.Parse(odpowiedźOdUżytkownika).

            string name;
            string surname;
            int phoneNumber;
            string eMail;
            int height;
            double weight;
            char gender;
            string pesel;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            Int32.TryParse(Console.ReadLine(), out phoneNumber);
            Console.WriteLine("Please enter e-mail adress: ");
            eMail = Console.ReadLine();
            Console.WriteLine("Please enter height in cm (example 174): ");
            Int32.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("Please enter your weight in kg (example 74,5): ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please choose your gender 'm' - man, 'w' - woman: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Please enter yout pesel: ");
            pesel = Console.ReadLine();

            Console.WriteLine($"Name: {name}, Surname: {surname}, Phone Number: {phoneNumber}, e-Mail: {eMail}, Height: {height}, Weight: {weight}, gender {gender}, PESEL: {pesel} ");
        }
        public void WarunkiZadanie1()
        {
            //            1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
            //one równe czy nie.
            //Dane testowe:
            //a: 5
            //b: 5
            //Rezultat w terminalu:
            //            5 i 5 są równe
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine("Variable 'a' and 'b' are the same");
            }
            else
            {
                Console.WriteLine("Variable 'a' and 'b' are different");
            }


        }
        public void WarunkiZadanie2()
        {
            //            2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            //jest parzysta czy nieparzysta.
            //Dane testowe : 15
            //Rezultat w terminalu:
            //            15 jest liczbą nieparzystą
            int number;
            Console.WriteLine("Please enter some integer and we will check is it even or odd: ");
            Int32.TryParse(Console.ReadLine(), out number);

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }



        }
        public void WarunkiZadanie3()
        {
            //            3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            //jest dodatnia czy ujemna.
            //Dane testowe : 14
            //Rezultat w terminalu:
            //            14 jest liczbą dodatnią

            int number;
            Console.WriteLine("Please enter some integer and we will check is it positive or negative: ");
            Int32.TryParse(Console.ReadLine(), out number);
            if (number >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }
        public void WarunkiZadanie4()
        {
            //            4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
            //jest rokiem przestępnym.
            //Dane testowe : 2016
            //Rezultat w terminalu:
            //            2016 jest rokiem przestępnym
            int year;
            Console.WriteLine("Please enter a year and we will check is it leap year or not: ");
            Int32.TryParse(Console.ReadLine(), out year);
            if (year % 4 == 0)
            {
                Console.WriteLine("Your year is leap year ");
            }
            else
            {
                Console.WriteLine("Your year is not leap year");
            }

        }
        public void WarunkiZadanie5()
        {
            //            5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
            //uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
            //prezydenta.
            //Dane testowe : 21
            //Rezultat w terminalu:
            //            Możesz zostać posłem
            // poseł‚ i senator muszą mieć skończone 21 lat
            // premier skonczone 30 lat
            // prezydent skoĹ„czone 35 lat


            int year;
            Console.WriteLine("Please enter how old are you and we will check are you provided to run for the position of MP, Prime Minister, Sentaror or President. ");
            Int32.TryParse(Console.ReadLine(), out year);
            if (year >= 21 && year < 30)
            {
                Console.WriteLine("You are provided to run for the position of MP and Senator, but not for Prime Minister or President.");
            }
            else if (year >=21 && year < 35)
            {
                Console.WriteLine("You are provided to run for the position of MP, Prime Minister, Sentaror but nor for a President.");
            }
            else if (year >= 35)
            {
                Console.WriteLine("You are provided to run for the position of MP, Prime Minister, Sentaror or President.");
            }
            else
            {
                Console.WriteLine("You are not provided to run for the position of MP, Prime Minister, Sentaror or President.");
            }
        }
        public void WarunkiZadanie6()
        {
            //            6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
            //wymyśloną kategorię wzrostu.
            //Dane testowe : 140
            //Rezultat w terminalu:
            //            Jesteś krasnoludem

            Console.WriteLine(" Please enter your height in cm: ");
            int height = int.Parse(Console.ReadLine());

            if (height <= 140)
            {
                Console.WriteLine("You are a dwarf");
            }
            else if (height < 140 && height <= 175)
            {
                Console.WriteLine("You are just right");
            }
            else
            {
                Console.WriteLine("You are tall");
            }
        }
        public void WarunkiZadanie7()
        {
            //            7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
            //która jest największa
            //Dane testowe:
            //25
            //63
            //79
            //Rezultat w terminalu:
            //            79 jest największa z podanych

            Console.WriteLine(" Please enter 3 intigers: ");
            Console.WriteLine("First: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Third: ");
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine($"Integer {a} is the largest");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"Integer {b} is the largest");
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine($"Integer {c} is the largest");
            }
            else
            {
                Console.WriteLine("No one number is highest");
            }

        }
        public void WarunkiZadanie8()
        {
            //            8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
            //na studiach wg.Następujących kryteriów:
            //Wynik z Matury z matematyki powyżej 70
            //Wynik z fizyki powyżej 55
            //Wynik z chemii powyżej 45
            //Łączny wynik z 3 przedmiotów powyżej 180
            //Albo
            //Wynik z matematyki i jednego przedmiotu powyżej 150
            //Dane testowe:
            //Matematyka 80
            //Fizyka 71
            //Chemia 0
            //Rezultat w terminalu:
            //            Kandydat dopuszczony do rekrutacji
            


            int matchResult;
            int physicResult;
            int chemistryResult;
            Console.WriteLine("Please enter your mathematics exam result: ");
            Int32.TryParse(Console.ReadLine(), out matchResult);
            Console.WriteLine("Please enter your physics exam result: ");
            Int32.TryParse(Console.ReadLine(), out physicResult);
            Console.WriteLine("Please enter your chemistry exam result: ");
            Int32.TryParse(Console.ReadLine(), out chemistryResult);

            if (matchResult > 70 && physicResult > 55 && chemistryResult > 45 && matchResult + physicResult + chemistryResult > 180)
            {
                Console.WriteLine("Passed");
            }
            else if (matchResult + physicResult > 150 || matchResult + chemistryResult > 150)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Didn't pass");
            }
        }
        public void WarunkiZadanie9()
        {
            //            9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w
            //poniższych kryteriach
            //Temp < 0 – cholernie piździ
            //Temp 0 – 10 – zimno
            //Temp 10 – 20 – chłodno
            //Temp 20 – 30 – w sam raz
            //Temp 30 – 40 – zaczyna być słabo, bo gorąco
            //Temp >= 40 – a weź wyprowadzam się na Alaskę.
            //Dane testowe : 41 Rezultat w terminalu: a weź wyprowadzam się na Alaskę.



            double temperature;
            Console.WriteLine("Please enter temperature: ");
            double.TryParse(Console.ReadLine(), out temperature);


            if (temperature < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }
        }
        public void WarunkiZadanie10()
        {
            //            10.Napisz program, który sprawdzi, czy z 3 podanych długości można
            //stworzyć trójkąt
            //Dane testowe: 40 55 65
            //Rezultat w terminalu:
            //            Można zbudować trójkąt
            Console.WriteLine("Enter the lengths of the sides of the triangle, from shortest to the longest");
            Console.WriteLine("First: ");
            int a;
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Second: ");
            int b;
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Third: ");
            int c;
            Int32.TryParse(Console.ReadLine(), out c);

            if (c < a + b && c > a && c > b)
            {
                Console.WriteLine("You can do triangle with this lenght of sides");
            }
            else
            {
                Console.WriteLine("You can't do triangle with this lenght of sides or you entered wrog data");
            }

        }

        public void WarunkiZadanie11()
        {
            //            11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            //Ocena Opis
            //6 Celujący
            //5 Bardzo dobry
            //4 Dobry
            //3 Dostateczny
            //2 Dopuszczający
            //1 Niedostateczny
            //Dane testowe: 3
            //Rezultat w terminalu:
            //            Dostateczny

            Console.WriteLine("Enter your garde");
            int grade;
            Int32.TryParse(Console.ReadLine(), out grade);

            switch (grade)
            {
                case 1: Console.WriteLine("Niedostateczny");
                    break;
                case 2: Console.WriteLine("Dopuszczający");
                    break;
                case 3: Console.WriteLine("Dostateczny");
                    break;
                case 4: Console.WriteLine("Dobry");
                    break;
                case 5: Console.WriteLine("Bardzo dobry");
                    break;
                case 6: Console.WriteLine("Celujący");
                    break;
            }

        }
        public void WarunkiZadanie12()
        {
            //            12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
            //nazwę
            //Dane testowe: 4
            //Rezultat w terminalu:
            //            Czwartek


            Console.WriteLine("Enter number of day of week");
            int day;
            Int32.TryParse(Console.ReadLine(), out day);

            switch (day)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
            }

        }
        public void WarunkiZadanie13()
        {
            //            13.Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I
            //będzie prostym kalkulatorem
            //Podaj pierwszą liczbę:
            //…
            //Podaj drugą liczbę:
            //…
            //Podaj numer operacji do wykonania:
            //                1.Dodawanie
            //2.Odejmowanie
            //3.Mnożenie
            //4.Dzielenie
            //…
            //Twój wynik to:
            int a;
            int b;
            Console.WriteLine("Enter firs number");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter second number");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Enter operation which you want to do");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int input;
            Int32.TryParse(Console.ReadLine(), out input);
            int result;
            switch (input)
            {
                case 1:
                    result = a + b; Console.WriteLine("Result of addition is: " + result);
                    break;
                case 2:
                    result = a - b; Console.WriteLine("Result of subtraction is: " + result);
                    break;
                case 3:
                    result = a * b; Console.WriteLine("Result of multiplication is: " + result);
                    break;
                case 4:
                    result = a / b; Console.WriteLine("Result of division is: " + result);
                    break;
            }

        }
        public void PętleZadanie1()
        {
            //1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            int result = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7 || i == 11)
                {
                    Console.Write($" {i}");
                    result = result + 1;
                }
                else if (i > 3 && i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
                {
                    Console.Write($" {i}");
                    result = result + 1;
                }
            }
            Console.WriteLine("\nResult: " + result);
        }
        public void PętleZadanie2()
        {
            //            2.Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
            //zakresu 0 – 1000.

            int result = 0;
            int number = 1;
            do
            {
                if (number % 2 == 0)
                {
                    result++;
                }
                number++;

            }
            while (number <= 1000);
            Console.WriteLine(result);
        }
        public void PętleZadanie3()
        {
            //3.Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            int first = 1;
            int second = 2;
            int third = 3;
            Console.Write($"{first}, {second}, {third}");
            do
            {

                first = third - first;
                second = third;
                third = first + second;
                Console.Write(", " + third);
            }
            while (first < 5000);
        }
        public void PętleZadanie4()
        {
            //            4.Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            //liczby w formie jak poniżej:
            //            1
            //2 3
            //4 5 6
            //7 8 9 10


            Console.WriteLine("Enter intiger: ");
            int number = int.Parse(Console.ReadLine());
            int row = 1;
            int column = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
                column++;
                if (column == row)
                {

                    Console.Write("\n");
                    row++;
                    column = 0;
                }
            }          

        }
        public void PętleZadanie5()
        {
            //5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            Console.WriteLine("Enter intiger: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(Math.Pow(i, 3) + " ");
            }
        }
        public void PętleZadanie6()
        {
            //6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.
            Console.WriteLine("Enter intiger: ");
            int number = int.Parse(Console.ReadLine());
            double result=0;

            for (int i = 1; i <= number; i++)
            {
                result = result + (1.0 / i);

            }
            Console.WriteLine(result);
        }
        public void PętleZadanie7()
        {
        //            7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
        //przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
        //              *
        //             ***
        //            *****
        //           *******
        //          *********
        //           *******
        //            *****
        //             ***
        //              *
                        Console.WriteLine("Enter intiger: ");
            int number = Int32.Parse(Console.ReadLine());
            
            int column = 1;
            int middleRaw = ((number - 1) / 2) + 1;
            int space = middleRaw - 1;
            int stars = 1;
            int lastRaw = 1;
            if (number %2 == 0)
            { stars = 2; }

            while (column < middleRaw)
            {
                for (int i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space--;
                for (int i = 1; i <= stars; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                column++;
                stars = stars + 2;
            }
            if (column == middleRaw)
            {
                for (int i = 1; i <= stars; i++)
                {
                    Console.Write("*");
                }
                column--;
                stars = stars - 2;
                space = 1;
                Console.Write("\n");
                while (column >= lastRaw)
                {
                    for (int i = 1; i <= space; i++)
                    {
                        Console.Write(" ");
                    }
                    space++;
                    for (int i = 1; i <= stars; i++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                    column--;
                    stars = stars - 2;
                }
            }

        }
        public void PętleZadanie8()
        {
            //            8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba
            Console.WriteLine("Wprowadź napis");
            string napis = Console.ReadLine();



            for (int i = napis.Count() - 1; i >= 0; i--)
            {
                Console.Write(napis[i]);
            }

        }
        public void PętleZadanie9()
        {
            //9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            Console.WriteLine("Wpisz liczbę dzięsiętną, którą chcesz zmienić na binarną: ");
            int a = int.Parse(Console.ReadLine());
            int b;
            string bin = "";
            do
            {
                b = a % 2;
                bin += b;
                a /=  2;                
            }
            while (a != 0);
            
            for (int d = bin.Length - 1; d >= 0; d--)
            {
                Console.Write(bin[d]);
            }
        }
        public void PętleZadanie10()
        {
            //10.Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            Console.WriteLine("Enter two numbers you want to find the least common multiple of: ");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());

            int a2ForCalculation = a1;
            int b2ForCalculation = b1;
            int divisionRest = 0;
            int lowerestdivider = 0;
            int result;
            if (a1 > b1 && a1 % b1 != 0)
            {
                do
                {
                    lowerestdivider = divisionRest;
                    divisionRest = a2ForCalculation % b2ForCalculation;
                    a2ForCalculation = b2ForCalculation;
                    b2ForCalculation = divisionRest;
                }
                while (divisionRest != 0);
                result = (a1 * b1) / lowerestdivider;
                Console.WriteLine("The least common multiple is: " + result);
            }
            else if (a1 > b1 && a1 % b1 == 0)
            {
                Console.WriteLine("The least common multiple is: " + a1);
            }
            else if (b1 > a1 && b1 % a1 == 0)
            {
                Console.WriteLine("The least common multiple is: " + b1);
            }
            else if (b1 > a1 && b1 % a1 != 0)
            {
                do
                {
                    lowerestdivider = divisionRest;
                    divisionRest = b2ForCalculation % a2ForCalculation;
                    b2ForCalculation = a2ForCalculation;
                    a2ForCalculation = divisionRest;
                }
                while (divisionRest != 0);
                result = (a1 * b1) / lowerestdivider;
                Console.WriteLine("The least common multiple is: " + result);
            }
        }
    }



}


















