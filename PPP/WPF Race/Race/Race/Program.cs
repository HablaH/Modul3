using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Race
{
    class Program
    {

        private static Label _label;
        private static int _count;

        [STAThread]
        public static void Main()
        {

            var application = new Application();
            var window = new Window();

            var car = new Car();
            
            var panel = new StackPanel();
            panel.Children.Add(car);
            window.Content = panel;

            application.Run(window);
        }

    }
}
