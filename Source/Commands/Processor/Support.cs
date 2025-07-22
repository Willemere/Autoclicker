using System;

namespace Yandex
{
    class SupportUsers
    {
        public static void Cleaning()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
            Registration.Type(0, 98, false, 0);
        }
    }
}
