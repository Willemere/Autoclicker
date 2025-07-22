using System.Collections.Generic;
using System.Reflection;

namespace Yandex
{
    class Language
    {
        public static string Translate(string value)
        {
            switch (Variables.langEng)
            {
                case "eng":
                    return eng[value];
                case "rus":
                    return rus[value];
                default:
                    return eng[value];
            }
        }

        public static Dictionary<string, string> eng = new Dictionary<string, string>
        {
            ["user"] = $"[red]yandex[/][white]@[/][red]{System.Security.Principal.WindowsIdentity.GetCurrent().Name}[/]",
            ["separator"] = $"[white]----------------------------[/]",
            ["welcome"] = $"[white]Welcome to [/][blue]Yandex[/] [white]Delivery![/]",
            ["version"] = $"[white]Version: [/][blue]{Assembly.GetEntryAssembly().GetName().Version}[/]",
            ["made"] = $"[white]Made by [/][blue]Willemere[/]",
            ["telegram"] = $"[white]Telegram: [/][blue link]t.me/winsShame[/]",
            ["vk"] = $"[white](VK)ontakte: [/][blue link]vk.com/podsq[/]",
            ["typehelp"] = $"[white]- Have you seen the [/][blue]commands[/][white]?[/]",
        };

        public static Dictionary<string, string> rus = new Dictionary<string, string>
        {
            ["user"] = $"[red]yandex[/][white]@[/][red]{System.Security.Principal.WindowsIdentity.GetCurrent().Name}[/]",
            ["separator"] = $"[white]----------------------------[/]",
            ["welcome"] = $"[white]Добро пожаловать в [/][blue]Yandex[/] [white]доставку![/]",
            ["version"] = $"[white]Версия: [/][blue]{Assembly.GetEntryAssembly().GetName().Version}[/]",
            ["made"] = $"[white]Софтинку создал [/][blue]Willemere[/]",
            ["telegram"] = $"[white]Телеграмм: [/][blue link]t.me/winsShame[/]",
            ["vk"] = $"[white](ВК)онтакте: [/][blue link]vk.com/podsq[/]",
            ["typehelp"] = $"[white]- Ты видел [/][blue]команды[/][white]?[/]",
        };

    }
}
