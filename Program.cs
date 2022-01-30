﻿using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle prostokat1 = new Rectangle(2, 2);
            prostokat1.Show();
            Rectangle.PrintClassName();

            Rectangle[] rectangles = new Rectangle[3];
            rectangles[0] = prostokat1;
            rectangles[1] = new Rectangle(4, 5);
            rectangles[2] = new Rectangle(5, 2);

            foreach(Rectangle rectangle in rectangles)
            {
                rectangle.Show();
            }

        }
    }
}