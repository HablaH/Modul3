using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Race
{
    class Car:FrameworkElement
    {
        private Rectangle chassis = new Rectangle();
        private int _speed = 1;
        private int _width;
        private int _height;
        private string _color;
        private int _turn;

        public Car()
        {
            _speed = 1;
            chassis.Width = 2;
            chassis.Height = 3;
            chassis.Fill = Brushes.DarkBlue;
            _turn = 2;
        }
        
    }
}
