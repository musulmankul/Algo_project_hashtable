using System;

namespace Algo_project_hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable tasks = new HashTable();

            while (true)
            {
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Удалить задачу");
                Console.WriteLine("3. Отметить задачу как выполненную");
                Console.WriteLine("4. Показать все задачи");
                Console.WriteLine("5. Выйти");
                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask(tasks);
                        break;
                    case 2:
                        DeleteTask(tasks);
                        break;
                    case 3:
                        MarkTaskAsDone(tasks);
                        break;
                    case 4:
                        ShowAllTasks(tasks);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }

        static void AddTask(HashTable tasks)
        {
            Console.Write("Введите название задачи: ");
            string taskName = Console.ReadLine();

            if (tasks.Get(taskName) == null)
            {
                tasks.Add(taskName, false);
                Console.WriteLine("Задача добавлена.");
            }
            else
            {
                Console.WriteLine("Задача с таким названием уже существует.");
            }
        }

        static void DeleteTask(HashTable tasks)
        {
            Console.Write("Введите название задачи для удаления: ");
            string taskName = Console.ReadLine();

            if (tasks.Remove(taskName))
            {
                Console.WriteLine("Задача удалена.");
            }
            else
            {
                Console.WriteLine("Задача не найдена.");
            }
        }

        static void MarkTaskAsDone(HashTable tasks)
        {
            Console.Write("Введите название задачи для отметки как выполненной: ");
            string taskName = Console.ReadLine();

            if (tasks.Get(taskName) != null)
            {
                tasks.Add(taskName, true);
                Console.WriteLine("Задача отмечена как выполненная.");
            }
            else
            {
                Console.WriteLine("Задача не найдена.");
            }
        }

        static void ShowAllTasks(HashTable tasks)
        {
            Console.WriteLine("Все задачи:");
            tasks.DisplayAll();
        }
    }
}