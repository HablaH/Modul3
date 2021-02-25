using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using SystemColors = System.Drawing.SystemColors;

namespace Race
{
    class BGScreen : StackPanel
    {
        private Label _label;
        private int _count;
        public BGScreen()
        {
            
            var button = new Button() { Content = "Klikk her" };
            _label = new Label();
            button.Click += ButtonClick;
            Children.Add(button);
            button.Width = 200;
            button.Height = 200;
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
