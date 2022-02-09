using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Control button = new Button(0, 0, " Submit");
            Control textBlock = new TextBlock(0, 0, "2022");

            List<Control> controls = new List<Control>();
            controls.Add(button);
            controls.Add(textBlock);

            foreach (var control in controls)
            {
                control.DrawMe();
            }

        }
    }
}
