namespace Yandex
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSettings.Start();
            Registration.Context();
            Users.Definition();
        }
    }
}
