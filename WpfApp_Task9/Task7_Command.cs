using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_Task9
{
    class Task7_Command
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand LightTheme { get; set; }
        public static RoutedUICommand DarkTheme { get; set; }
        static Task7_Command()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            inputs.Add(new KeyGesture(Key.L, ModifierKeys.Control, "Ctrl+L"));
            inputs.Add(new KeyGesture(Key.D, ModifierKeys.Control, "Ctrl+D"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(Task7_Command), inputs);
            LightTheme = new RoutedUICommand("Светлая", "LightTheme", typeof(Task7_Command), inputs);
            DarkTheme = new RoutedUICommand("Темная", "DarkTheme", typeof(Task7_Command), inputs);
        }
    }
}
