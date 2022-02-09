using System;
namespace Abstraction
{
    public abstract class Control
    {
        //fields not properties
        protected int top; 
        protected int left;

        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public Control(): this(0,0)// default constructor
        {
        }

        public abstract void DrawMe();

    }

    public class Button: Control
    {
        public string Contents { get; private set; } // we dont want anyone to set the value directly

        public Button(int top, int left, string contents):
            base(top, left)
        {
            Contents = contents;
        }

        public override void DrawMe()
        {
            Console.WriteLine("Drawing button with contents: "+ Contents);
        }
    }

    public class TextBlock: Control
    {
        public string Text { get; private set; } 

        public TextBlock(int top, int left, string text) :
            base(top, left)
        {
            Text = text;
        }

        public override void DrawMe()
        {
            Console.WriteLine("Drawing text box with text: " + Text);
        }
    }
}
