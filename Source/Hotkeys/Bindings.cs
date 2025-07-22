using System.Windows.Forms;

namespace Yandex
{
    class Bindings
    {
        public static bool isKeyHold(Keys key)
        {
            if (Imports.GetAsyncKeyState(key) < 0)
            {
                return true;
            }
            return false;
        }

        public static bool isKeyUp(Keys key)
        {
            if (Imports.GetAsyncKeyState(key) >= 0)
            {
                return true;
            }
            return false;
        }

        public static bool isKeyPress(Keys key, ref bool handled)
        {
            if ((Imports.GetAsyncKeyState(key) < 0) && handled == false)
            {
                handled = true;
                return true;
            }
            else if (Imports.GetAsyncKeyState(key) == 0)
            {
                handled = false;
            }
            return false;
        }
    }
}
