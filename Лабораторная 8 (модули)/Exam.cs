using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8__модули_
{
    class Exam : Ticket
    {
        public string Name { get; set; }
       // public DateTime BirthDay { get; set; }
        public int Mark { get; set; }
        public List<int> Marks { get; set; }
        public Exam() { }
        public Exam(string name, DateTime birthday)
        {
            Name = name;
         //   BirthDay = birthday;
            Examen();
            Mark = 1; //начальное значение оценки

            Marks = new List<int> { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) }; // Создание списка оценок из трех значений, введенных пользователем с консоли

        }
        public void PrintMark()
        {
            Console.WriteLine("Дополнительный любимый вопрос: Во сколько у вас ужин?");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 2:
                    foreach (int i in Marks)
                    {
                        Mark += i;
                    }
                    Console.WriteLine($"ФИО-{Name}\tОценка-{Mark /= 3}");
                    break;
                default: foreach (int i in Marks) { Console.WriteLine($"Оценка: {i}"); } // Вывод каждой оценки из списка
                    break;

            }
        }
        private void Examen()
        {
            Tasks = new List<string> { "Найдите отношение 2,5 к 0,05",
                                      "За 5 кг апельсинов заплатили 150 руб. Сколько рублей следует заплатить за 2,5 кг апельсинов?",
                                      "Решите уравнение: 2 х = - 6,2",
                                      "Рассчитайте вероятность того, что билет выпадет удачным", 
                                      "Определить, сколько секунд в одной минуте",
                                      "Решите уравнение: 4 х = 20", 
                                      "Реализовать программу на С#",
                                      "Найти значение выражения 5х + 25 = 125",
                                      "Решите уравнение: 12х + 6у - 7 = 347",
                                      "Написать самостоятельно себе задачу" };
            Question = new List<string> { "Лежит ли Париж в России?",
                                    "Является ли Африка континентом?",
                                    "Проходила ли Великая Китайская стена через США?",
                                    "Можно ли увидеть Северное сияние в Австралии?",
                                    "Является ли Аляска островом?",
                                    "Является ли 7 простым числом?",
                                    "10 умножить на 5 равно 50?",
                                    "25 больше чем 30?",
                                    "3 в степени 4 равно 81?",
                                    "Можно ли управлять сновидениями?",
                                    "Веришь ли ты в психические явления?",
                                    "Могут ли мечты предсказывать будущее?",
                                    "Бывают ли у тебя дежавю?",
                                    "Может ли цвет влиять на настроение?",
                                    "вляется ли Египет страной в Азии?",
                                    "Знаешь ли ты, что такое HTML?",
                                    "Понимаешь ли ты, что такое алгоритм?",
                                    "Знаешь ли ты разницу между Wi-Fi и Bluetooth?",
                                    "Имеешь ли ты аккаунт на GitHub?",
                                    "Знаешь ли ты, что такое искусственный интеллект?" };
            Tickets = new List<string>();
            for (int i = 0; i < 10; i++)// Цикл для создания 10 билетов
            {
                    Tickets.Add("Вопрос 1: " + Question[i] + " Вопрос 2: " + Question[Question.Count - 1 - i] + "Задача: " + Tasks[i]); // Добавление элемента в список билетов
            }
            Random rnd = new Random(); // Создание экземпляра генератора случайных чисел
            string bilet = Tickets[rnd.Next(0, 10)]; // Получение случайного билета из списка
            Console.WriteLine(bilet);
            Answer = new List<string>(); // Создание списка ответов
            Answer.Add("Ответ 1:" + Console.ReadLine() + " Ответ 2:" + Console.ReadLine() + " Ответ 3:" + Console.ReadLine());
            foreach (var elem in Answer) // Этот цикл выводит каждый элемент списка
            {
                Console.WriteLine(elem);
            }
        }
    }
}
