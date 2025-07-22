using Spectre.Console;
using System;

namespace Yandex
{
    class Registration
    {
        public static void Context()
        {
            Shift(Language.Translate("user"), 24);
            Shift(Language.Translate("separator"), 0);
            Shift(Language.Translate("welcome"), 0);
            Shift(Language.Translate("version"), 0);
            Shift(Language.Translate("made"), 0);
            Shift(Language.Translate("telegram"), 0);
            Shift(Language.Translate("vk"), 0);
            Shift(Language.Translate("typehelp"), 0, 40, true, 11);
            Bar(0, 40, 1, false);
            Bar(0, 40, 0, true);
            Type();
        }

        // I see <variable> -_-
        public static void TestCommand(string action)
        {
            Console.Title = Variables.titleApp + " | " + action;
        }

        public static void Shift(string value, int cursor = 0, int offset = 40, bool shift = false, int top = 15)
        {
            int consoleWidth = Console.WindowWidth;
            if (shift)
            {
                Console.SetCursorPosition(consoleWidth - offset, Console.CursorTop + top);
                AnsiConsole.MarkupLine(value);
            }
            else
            {
                Console.SetCursorPosition(consoleWidth - offset, Console.CursorTop - cursor);
                AnsiConsole.MarkupLine(value);
            }
        }



        public static void Bar(int cursor = 0, int offset = 40, int top = 0, bool value = false)
        {
            int consoleWidth = Console.WindowWidth;
            var breakDown = new BreakdownChart();

            Console.SetCursorPosition(consoleWidth - offset, Console.CursorTop + top);

            breakDown.ShowTags = false;
            breakDown.Width = 32;
            if (!value)
            {
                breakDown.AddItem("", 4, Color.FromHex("#101116"));
                breakDown.AddItem("", 4, Color.FromHex("#ff567f"));
                breakDown.AddItem("", 4, Color.FromHex("#00ff9b"));
                breakDown.AddItem("", 4, Color.FromHex("#fefc57"));
                breakDown.AddItem("", 4, Color.FromHex("#00b0fe"));
                breakDown.AddItem("", 4, Color.FromHex("#d47bfe"));
                breakDown.AddItem("", 4, Color.FromHex("#75c1fe"));
                breakDown.AddItem("", 4, Color.FromHex("#c7c7c7"));
            }
            else
            {
                breakDown.AddItem("", 6, Color.FromHex("#676767"));
                breakDown.AddItem("", 6, Color.FromHex("#ff6d67"));
                breakDown.AddItem("", 6, Color.FromHex("#5ff967"));
                breakDown.AddItem("", 6, Color.FromHex("#fefb67"));
                breakDown.AddItem("", 6, Color.FromHex("#6871ff"));
                breakDown.AddItem("", 6, Color.FromHex("#d582eb"));
                breakDown.AddItem("", 6, Color.FromHex("#5ffdff"));
                breakDown.AddItem("", 6, Color.FromHex("#feffff"));
            }

            AnsiConsole.Write(breakDown);
        }

        public static void Type(int cursor = 0, int offset = 98, bool shift = false, int top = 3)
        {
            int consoleWidth = Console.WindowWidth;
            Console.SetCursorPosition(consoleWidth - offset, Console.CursorTop + top);
            AnsiConsole.Markup($"[red]yandex[/]@[red]{System.Security.Principal.WindowsIdentity.GetCurrent().Name}[/][white]:[/][blue]⁓$ [/]", Color.White);
        }
    }
}
