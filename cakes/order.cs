using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cakes
{
    internal class order
    {
        public static void Menu()
        {
            int _check = 0;
            Console.WriteLine("соберите свой собственный торт");
            Console.WriteLine("  форма");
            Console.WriteLine("  размер");
            Console.WriteLine("  вкус коржей");
            Console.WriteLine("  количество коржей");
            Console.WriteLine("  глазурь");
            Console.WriteLine("  декор");
            Console.WriteLine("  конец заказа");

            int pos = 1;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            ConsoleKeyInfo cursor = Console.ReadKey();
            while (cursor.Key != ConsoleKey.Escape)
            {
                if (cursor.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, pos++);
                    Console.WriteLine("->");

                }
                else if (cursor.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, pos--);
                    Console.WriteLine("->");
                }
                if (pos == 0)
                {

                }
                if(cursor.Key == ConsoleKey.Enter && pos == 1)
                {
                    Console.Clear();
                    submenu sub_1 = new submenu("  квадратный", 200);
                    submenu sub_2 = new submenu("  круглый", 200);
                    submenu sub_3 = new submenu("  треугольный", 150);
                    sub_1.Feautres();
                    sub_2.Feautres();
                    sub_3.Feautres();
                    int subPos = 0;
                    Console.SetCursorPosition(0, subPos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo subCur = Console.ReadKey();
                    while(subCur.Key != ConsoleKey.Enter)
                    {
                        if (subCur.Key == ConsoleKey.DownArrow)
                        {
                            Console.SetCursorPosition(0, subPos++);
                            Console.WriteLine("->");
                        }
                        if (subCur.Key == ConsoleKey.UpArrow)
                        {
                            Console.SetCursorPosition(0, subPos--);
                            Console.WriteLine("->");
                        }
                        if (subPos == 0)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_1.desc + " - " + sub_1.cost);
                            }
                        }
                        if (subPos == 1)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_2.desc + " - " + sub_2.cost);
                            }
                        }
                        if (subPos == 2)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_3.desc + " - " + sub_3.cost);
                            }
                        }
                        Console.Clear();
                        sub_1.Feautres();
                        sub_2.Feautres();
                        sub_3.Feautres();
                        Console.SetCursorPosition(0, subPos);
                        Console.WriteLine("->");
                        subCur = Console.ReadKey();
                    }
                }
                if (cursor.Key == ConsoleKey.Enter && pos == 2)
                {
                    Console.Clear();
                    submenu sub_1 = new submenu("  маленький", 150);
                    submenu sub_2 = new submenu("  средний", 200);
                    submenu sub_3 = new submenu("  большой", 250);
                    sub_1.Feautres();
                    sub_2.Feautres();
                    sub_3.Feautres();
                    int subPos = 0;
                    Console.SetCursorPosition(0, subPos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo subCur = Console.ReadKey();
                    while (subCur.Key != ConsoleKey.Enter)
                    {
                        if (subCur.Key == ConsoleKey.DownArrow)
                        {
                            Console.SetCursorPosition(0, subPos++);
                            Console.WriteLine("->");
                        }
                        if (subCur.Key == ConsoleKey.UpArrow)
                        {
                            Console.SetCursorPosition(0, subPos--);
                            Console.WriteLine("->");
                        }
                        if (subPos == 0)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_1.desc + " - " + sub_1.cost);
                            }
                        }
                        if (subPos == 1)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_2.desc + " - " + sub_2.cost);
                            }
                        }
                        if (subPos == 2)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_3.desc + " - " + sub_3.cost);
                            }
                        }
                        Console.Clear();
                        sub_1.Feautres();
                        sub_2.Feautres();
                        sub_3.Feautres();
                        Console.SetCursorPosition(0, subPos);
                        Console.WriteLine("->");
                        subCur = Console.ReadKey();
                    }
                }
                if (cursor.Key == ConsoleKey.Enter && pos == 3)
                {
                    Console.Clear();
                    submenu sub_1 = new submenu("  клубника", 200);
                    submenu sub_2 = new submenu("  карамель", 200);
                    submenu sub_3 = new submenu("  шоколад", 200);
                    sub_1.Feautres();
                    sub_2.Feautres();
                    sub_3.Feautres();
                    int subPos = 0;
                    Console.SetCursorPosition(0, subPos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo subCur = Console.ReadKey();
                    while (subCur.Key != ConsoleKey.Enter)
                    {
                        if (subCur.Key == ConsoleKey.DownArrow)
                        {
                            Console.SetCursorPosition(0, subPos++);
                            Console.WriteLine("->");
                        }
                        if (subCur.Key == ConsoleKey.UpArrow)
                        {
                            Console.SetCursorPosition(0, subPos--);
                            Console.WriteLine("->");
                        }
                        if (subPos == 0)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_1.desc + " - " + sub_1.cost);
                            }
                        }
                        if (subPos == 1)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_2.desc + " - " + sub_2.cost);
                            }
                        }
                        if (subPos == 2)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_3.desc + " - " + sub_3.cost);
                            }
                        }
                        Console.Clear();
                        sub_1.Feautres();
                        sub_2.Feautres();
                        sub_3.Feautres();
                        Console.SetCursorPosition(0, subPos);
                        Console.WriteLine("->");
                        subCur = Console.ReadKey();
                    }
                }
                if (cursor.Key == ConsoleKey.Enter && pos == 4)
                {
                    Console.Clear();
                    submenu sub_1 = new submenu("  два", 200);
                    submenu sub_2 = new submenu("  три", 300);
                    submenu sub_3 = new submenu("  четыре", 400);
                    sub_1.Feautres();
                    sub_2.Feautres();
                    sub_3.Feautres();
                    int subPos = 0;
                    Console.SetCursorPosition(0, subPos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo subCur = Console.ReadKey();
                    while (subCur.Key != ConsoleKey.Enter)
                    {
                        if (subCur.Key == ConsoleKey.DownArrow)
                        {
                            Console.SetCursorPosition(0, subPos++);
                            Console.WriteLine("->");
                        }
                        if (subCur.Key == ConsoleKey.UpArrow)
                        {
                            Console.SetCursorPosition(0, subPos--);
                            Console.WriteLine("->");
                        }
                        if (subPos == 0)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_1.desc + " - " + sub_1.cost);
                            }
                        }
                        if (subPos == 1)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_2.desc + " - " + sub_2.cost);
                            }
                        }
                        if (subPos == 2)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_3.desc + " - " + sub_3.cost);
                            }
                        }
                        Console.Clear();
                        sub_1.Feautres();
                        sub_2.Feautres();
                        sub_3.Feautres();
                        Console.SetCursorPosition(0, subPos);
                        Console.WriteLine("->");
                        subCur = Console.ReadKey();
                    }
                }
                if (cursor.Key == ConsoleKey.Enter && pos == 5)
                {
                    Console.Clear();
                    submenu sub_1 = new submenu("  молочный шоколад", 200);
                    submenu sub_2 = new submenu("  горький шоколад", 200);
                    submenu sub_3 = new submenu("  белый шоколад", 200);
                    sub_1.Feautres();
                    sub_2.Feautres();
                    sub_3.Feautres();
                    int subPos = 0;
                    Console.SetCursorPosition(0, subPos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo subCur = Console.ReadKey();
                    while (subCur.Key != ConsoleKey.Enter)
                    {
                        if (subCur.Key == ConsoleKey.DownArrow)
                        {
                            Console.SetCursorPosition(0, subPos++);
                            Console.WriteLine("->");
                        }
                        if (subCur.Key == ConsoleKey.UpArrow)
                        {
                            Console.SetCursorPosition(0, subPos--);
                            Console.WriteLine("->");
                        }
                        if (subPos == 0)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_1.desc + " - " + sub_1.cost);
                            }
                        }
                        if (subPos == 1)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_2.desc + " - " + sub_2.cost);
                            }
                        }
                        if (subPos == 2)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_3.desc + " - " + sub_3.cost);
                            }
                        }
                        Console.Clear();
                        sub_1.Feautres();
                        sub_2.Feautres();
                        sub_3.Feautres();
                        Console.SetCursorPosition(0, subPos);
                        Console.WriteLine("->");
                        subCur = Console.ReadKey();
                    }
                }
                if (cursor.Key == ConsoleKey.Enter && pos == 6)
                {
                    Console.Clear();
                    submenu sub_1 = new submenu("  кокосовая стружка", 200);
                    submenu sub_2 = new submenu("  мастика", 300);
                    submenu sub_3 = new submenu("  шоколадная стружка", 150);
                    sub_1.Feautres();
                    sub_2.Feautres();
                    sub_3.Feautres();
                    int subPos = 0;
                    Console.SetCursorPosition(0, subPos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo subCur = Console.ReadKey();
                    while (subCur.Key != ConsoleKey.Enter)
                    {
                        if (subCur.Key == ConsoleKey.DownArrow)
                        {
                            Console.SetCursorPosition(0, subPos++);
                            Console.WriteLine("->");
                        }
                        if (subCur.Key == ConsoleKey.UpArrow)
                        {
                            Console.SetCursorPosition(0, subPos--);
                            Console.WriteLine("->");
                        }
                        if (subPos == 0)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_1.desc + " - " + sub_1.cost);
                            }
                        }
                        if (subPos == 1)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_2.desc + " - " + sub_2.cost);
                            }
                        }
                        if (subPos == 2)
                        {
                            if (subCur.Key == ConsoleKey.Enter)
                            {
                                File.WriteAllText("C:\\Users\\keylo\\OneDrive\\Рабочий стол\\order.txt", sub_3.desc + " - " + sub_3.cost);
                            }
                        }
                        Console.Clear();
                        sub_1.Feautres();
                        sub_2.Feautres();
                        sub_3.Feautres();
                        Console.SetCursorPosition(0, subPos);
                        Console.WriteLine("->");
                        subCur = Console.ReadKey();
                    }
                }
                if(cursor.Key == ConsoleKey.Enter && pos == 7)
                {
                    Console.Clear();
                    Console.WriteLine("спасибо за заказ! НАжмите ESC для выхода");
                    ConsoleKeyInfo exit = Console.ReadKey();
                    while (true)
                    {
                        if (exit.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                        else
                        {

                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("соберите свой собственный торт");
                Console.WriteLine("  форма");
                Console.WriteLine("  размер");
                Console.WriteLine("  вкус коржей");
                Console.WriteLine("  количество коржей");
                Console.WriteLine("  глазурь");
                Console.WriteLine("  декор");
                Console.WriteLine("  конец заказа");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                cursor = Console.ReadKey();
            }
        }
    }
}