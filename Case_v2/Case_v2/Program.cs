namespace Case2
{
    internal class Program
    {
        public static void Main()
        {
            // Case1. Дано целое число в диапазоне 1–7. Вывести строку — название дня недели, соответствующее данному числу
            // (1 — «понедельник», 2 — «вторник» и т. д.).
            /*
            int dayOfWeek = 4;
            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("пн"); break;
                case 2: Console.WriteLine("вт"); break;
                case 3: Console.WriteLine("ср"); break;
                case 4: Console.WriteLine("чт"); break;
                case 5: Console.WriteLine("пт"); break;
                case 6: Console.WriteLine("сб"); break;
                case 7: Console.WriteLine("вс"); break;
            }
           */
            // Case2. Дано целое число K. Вывести строку-описание оценки, соответствующей числу K 
            //     (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»).
            //     Если K не лежит в диапазоне 1–5, то вывести строку «ошибка».
            /*
            int k = 5;
            switch (k)
            {
                case 1: Console.WriteLine("плохо"); break;
                case 2: Console.WriteLine("неудовлетворительно"); break;
                case 3: Console.WriteLine("удовлетворительно"); break;
                case 4: Console.WriteLine("хорошо"); break;
                case 5: Console.WriteLine("отлично"); break;
                default: Console.WriteLine("ошибка"); break;
            }
            */
            // Case3. Дан номер месяца целое число в диапазоне 1–12 (1 — январь, 2 — февраль и т. д.). 
            //     Вывести название соответствующего времени года («зима», «весна», «лето», «осень»).
            /*
            int month = 12;
            switch (month)
            {
                case 12 or 1 or 2: Console.WriteLine("зима"); break;
                case 3 or 4 or 5: Console.WriteLine("весна"); break; 
                case 6 or 7 or 8: Console.WriteLine("лето"); break;
                case 9 or 10 or 11: Console.WriteLine("осень"); break;
            }
           */
            // Case4◦. Дан номер месяца целое число в диапазоне 1–12 (1 — январь, 2 — февраль и т. д.). 
            //     Определить количество дней в этом месяце для невисокосного года.
            /*
            int month = 12;
            switch (month)
            { 
                case 1: Console.WriteLine("31 день"); break;
                case 2: Console.WriteLine("28 дней"); break;
                case 3: Console.WriteLine("31 день"); break;
                case 4: Console.WriteLine("30 дней"); break;
                case 5: Console.WriteLine("31 день"); break;
                case 6: Console.WriteLine("30 дней"); break;
                case 7: Console.WriteLine("31 день"); break;
                case 8: Console.WriteLine("31 день"); break;
                case 9: Console.WriteLine("30 дней"); break;
                case 10: Console.WriteLine("31 день"); break;
                case 11: Console.WriteLine("30 дней"); break;
                case 12: Console.WriteLine("31 день"); break;
            }
            */
            // Case5. Арифметические действия над числами пронумерованы следующим образом: 1 — сложение, 2 — вычитание, 
            // 3 — умножение, 4 — деление. Дан номер действия N (целое число в диапазоне 1–4)
            // и вещественные числа A и B (В не равно 0). Выполнить над числами указанное действие и вывести результат.
            /*
            int toDO = 1;
            double a = 10.3, b = 20.7;
            switch (toDO)
            {
                case 1: Console.WriteLine(a + b); break;
                case 2: Console.WriteLine(a - b); break;
                case 3: Console.WriteLine(a * b); break;
                case 4: Console.WriteLine(a / b); break;
            }
            */
            // Case6. Единицы длины пронумерованы следующим образом: 1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 
            // 5 — сантиметр. Дан номер единицы длины (целое число в диапазоне 1–5) и длина отрезка 
            //     в этих единицах (вещественное число). Найти длину отрезка в метрах.
            /*
            int unit = 5;
            double lenght = 10.3;
            switch (unit)
            {
                case 1: Console.WriteLine($"{lenght / 10} м"); break;
                case 2: Console.WriteLine($"{lenght * 1000} м"); break;
                case 3: Console.WriteLine($"{lenght} м"); break;
                case 4: Console.WriteLine($"{lenght / 1000} м"); break;
                case 5: Console.WriteLine($"{lenght / 100} м"); break;
            }
            */
            // Case7. Единицы массы пронумерованы следующим образом: 1 — килограмм, 2 — миллиграмм, 3 — грамм, 4 — тонна,
            // 5 — центнер. Дан номер едини- цы массы (целое число в диапазоне 1–5) и масса тела 
            //     в этих единицах (вещественное число). Найти массу тела в килограммах.
            /*
            int unit = 3;
            double weight = 100.3;
            switch (unit)
            {
                case 1: Console.WriteLine($"{weight} кг"); break;
                case 2: Console.WriteLine($"{weight / 10000} кг"); break;
                case 3: Console.WriteLine($"{weight /1000} кг"); break;
                case 4: Console.WriteLine($"{weight * 1000} кг"); break;
                case 5: Console.WriteLine($"{weight * 100} кг"); break;
            }
            */
            // Case8. Даны два целых числа: D (день) и M (месяц), определяющие правильную дату невисокосного года. 
            //     Вывести значения D и M для даты, предшествующей указанной.
            /*
            int m = 3, d = 1;
            switch (m)
            {
                case 1:
                    if (d == 1)
                    {
                        d = 31;
                        m = 12;
                        break;
                    }
                    else
                    {
                        d -= 1;
                        break;
                    }
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    if (d == 1)
                    {
                        d = 31;
                        m -= 1;
                        break;
                    }
                    else
                    {
                        d -= 1;
                        break;
                    }
                case 3:
                    if (d == 1)
                    {
                        d = 28;
                        m -= 1;
                        break;
                    }
                    else
                    {
                        d -= 1;
                        break;
                    }
                case 5:
                case 7:
                case 10:
                case 12:
                    if (d == 1)
                    {
                        d = 30;
                        m -= 1;
                        break;
                    }
                    else
                    {
                        d -= 1;
                        break;
                    }
            }

            Console.WriteLine($"предшествующий день: {d} \nМесяц: {m}");
            }
           */


            // Case16. Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание
            // указанного возраста, обеспечив правильное согласование числа со словом «год», 
            // например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».


            // Case17. Дано целое число в диапазоне 10–40, определяющее количество учебных заданий по некоторой теме. 
            //     Вывести строку-описание указанного количества заданий, обеспечив правильное согласование числа со 
            // словами «учебное задание», например: 18 — «восемнадцать учебных заданий»,
            // 23 — «двадцать три учебных задания», 31 — «тридцать одно учебное задание».
            /*
            Console.Write("Введите число: ");
            int taskCount = int.Parse(Console.ReadLine());
            if (taskCount >= 10 && taskCount < 20)
            {
                switch (taskCount)
                {
                    case 10: Console.Write("десять "); break;
                    case 11: Console.Write("одинадцать "); break;
                    case 12: Console.Write("двенадцать "); break;
                    case 13: Console.Write("тринадцать "); break;
                    case 14: Console.Write("четырнадцать "); break;
                    case 15: Console.Write("пятнадцать "); break;
                    case 16: Console.Write("шестнадцать "); break;
                    case 17: Console.Write("семнадцать "); break;
                    case 18: Console.Write("восемнадцать "); break;
                    case 19: Console.Write("дявятнадцать "); break;
                }
                Console.WriteLine("учебных заданий"); return;
            }
            switch (taskCount / 10)
            {
                case 2: Console.Write("двадцать "); break;
                case 3: Console.Write("тридцать "); break;
                case 4: Console.Write("сорок "); break;
            }

            switch (taskCount % 10)
            {
                case 0:
                    Console.Write("учебных заданий "); return; 
                case 1: Console.Write("одно учебное задание "); return;
                case 2: Console.Write("два "); break;
                case 3: Console.Write("три задания"); return;
                case 4: Console.Write("четыре "); break;
                case 5: Console.Write("пять "); break;
                case 6: Console.Write("шесть "); break;
                case 7: Console.Write("семь "); break;
                case 8: Console.Write("восемь "); break;
                case 9: Console.Write("девять "); break;
            }
            Console.WriteLine("учебных заданий");
            */
            // Case18. Дано целое число в диапазоне 100–999. Вывести строку описание
            // данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать»
            /*
             Console.Write("Введите число: ");
             int Count = int.Parse(Console.ReadLine());
             if (Count >= 100 && Count < 1000)
                 switch (Count/100)
                 {
                     case 1: Console.Write("сто "); break;
                     case 2: Console.Write("двести "); break;
                     case 3: Console.Write("триста "); break;
                     case 4: Console.Write("четыреста "); break;
                     case 5: Console.Write("пятьсот "); break;
                     case 6: Console.Write("шестьсот "); break;
                     case 7: Console.Write("семьсот "); break;
                     case 8: Console.Write("восемьсот "); break;
                     case 9: Console.Write("девятьсоть "); break;
                     
                 }
             switch (Count / 10 % 10)
             {
                 case 2: Console.Write("двадцать "); break;
                 case 3: Console.Write("тридцать "); break;
                 case 4: Console.Write("сорок "); break;
                 case 5: Console.Write("пятьдесят "); break;
                 case 6: Console.Write("шестьдесят "); break;
                 case 7: Console.Write("семьдесят "); break;
                 case 8: Console.Write("восемьдесят "); break;
                 case 9: Console.Write("девяносто "); break;
             }
            
             {
                 switch (Count % 100 )
                 {
                     case 10: Console.Write("десять ");  return;
                     case 11: Console.Write("одинадцать ");  return;
                     case 12: Console.Write("двенадцать ");  return;
                     case 13: Console.Write("тринадцать ");  return;
                     case 14: Console.Write("четырнадцать ");  return;
                     case 15: Console.Write("пятнадцать ");  return;
                     case 16: Console.Write("шестнадцать ");  return;
                     case 17: Console.Write("семнадцать ");  return;
                     case 18: Console.Write("восемнадцать "); return;
                     case 19: Console.Write("дявятнадцать "); return;
                 }
             }
             switch (Count % 10)
             {
                 case 1: Console.Write("один "); return;
                 case 2: Console.Write("два "); break;
                 case 3: Console.Write("три"); return;
                 case 4: Console.Write("четыре "); break;
                 case 5: Console.Write("пять "); break;
                 case 6: Console.Write("шесть "); break;
                 case 7: Console.Write("семь "); break;
                 case 8: Console.Write("восемь "); break;
                 case 9: Console.Write("девять "); break;
             }
             */
            // Case19. В восточном календаре принят 60-летний цикл, состоящий из 12-
            //     летних подциклов, обозначаемых названиями цвета: зеленый, красный, желтый, белый и черный.
            //     В каждом подцикле годы носят названия животных: 
            // крысы, коровы, тигра, зайца, дракона, змеи, лошади, овцы, обезьяны, курицы, собаки и свиньи.
            //     По номеру года определить его название, если 1984 год — начало цикла: «год зеленой крысы».
            /*
           Console.Write("Введите число: ");
            int calendar = int.Parse(Console.ReadLine());
            if (calendar >= 1984 && calendar <= 2043)
            {
                Console.Write("год ");
                switch (calendar % 10)
                {
                    case 0 or 1: Console.Write("белый "); break;
                    case 2 or 3: Console.Write("черный "); break;
                    case 4 or 5: Console.Write("зеленый "); break;
                    case 6 or 7: Console.Write("красный "); break;
                    case 8 or 9: Console.Write("желтый "); break;
                }
            switch (calendar % 100)
                {
                case 84 or 96 or 08 or 20 or 32: Console.Write("крысы ");  return;
                case 85 or 97 or 09 or 21 or 33: Console.Write("коровы ");  return;
                case 86 or 98 or 10 or 22 or 34: Console.Write("тигра ");  return;
                case 87 or 99 or 11 or 23 or 35: Console.Write("зайца ");  return;
                case 88 or 00 or 12 or 24 or 36: Console.Write("дракона ");  return;
                case 89 or 01 or 13 or 25 or 37: Console.Write("змеи ");  return;
                case 90 or 02 or 14 or 26 or 38: Console.Write("лошади ");  return;
                case 91 or 03 or 15 or 27 or 39: Console.Write("овцы ");  return;
                case 92 or 04 or 16 or 28 or 40: Console.Write("обезьяны ");  return;
                case 93 or 05 or 17 or 29 or 41: Console.Write("курицы ");  return;
                case 94 or 06 or 18 or 30 or 42: Console.Write("собаки ");  return;
                case 95 or 07 or 19 or 31 or 43: Console.Write("свиньи ");  return;
                }
            }
            else 
                Console.WriteLine("Error");
            */
            // Case20. Даны два целых числа: D (день) и M (месяц), определяющие правильную дату.Вывести знак Зодиака, 
            //     соответствующий этой дате: «Водолей» (20.1–18.2), «Рыбы» (19.2–20.3), «Овен» (21.3–19.4),
            //     «Телец» (20.4– 20.5), «Близнецы» (21.5–21.6), «Рак» (22.6–22.7), «Лев» (23.7–22.8), «Дева» (23.8–22.9),
            //     «Весы» (23.9–22.10), «Скорпион» (23.10–22.11), «Стрелец» (23.11–21.12), «Козерог» (22.12–19.1).
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1: if (day > 19) Console.WriteLine("Водолей");
                    else Console.WriteLine("козерог"); return;
                case 2: if (day > 18) Console.WriteLine("Рыбы");
                    else Console.WriteLine("Водолей"); return;
                case 3: if (day > 20) Console.WriteLine("Овен");
                    else Console.WriteLine("Рыбы"); return;
                case 4: if (day > 19) Console.WriteLine("Телец");
                    else Console.WriteLine("Овен"); return;
                case 5: if (day > 20) Console.WriteLine("Близнецы");
                    else Console.WriteLine("Телец"); return;
                case 6: if (day > 21) Console.WriteLine("Рак");
                    else Console.WriteLine("Близнецы"); return;
                case 7: if (day > 22) Console.WriteLine("Лев");
                    else Console.WriteLine("Рак"); return;
                case 8: if (day > 22) Console.WriteLine("Дева");
                    else Console.WriteLine("Лев"); return;
                case 9: if (day > 22) Console.WriteLine("Весы");
                    else Console.WriteLine("Дева"); return;
                case 10: if (day > 22) Console.WriteLine("Скорпион");
                    else Console.WriteLine("Весы"); return;
                case 11: if (day > 22) Console.WriteLine("Стрелец");
                    else Console.WriteLine("Скорпион"); return;
                case 12: if (day > 21) Console.WriteLine("Козерог");
                    else Console.WriteLine("Стрелец"); return;
            }
        }
    }
}
