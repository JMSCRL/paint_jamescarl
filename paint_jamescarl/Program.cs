using System;

namespace paint_jamescarl
{
    class Program
    {
        static void Main(string[] args)
        {
            var PencilTool = new Pencil();
            PencilTool.MouseUp();
            PencilTool.MouseOver();

            var circleTool = new circle();
            circleTool.MouseUp();
            circleTool.MouseOver();

            var EraserTool = new Eraser();
            EraserTool.MouseUp();
            EraserTool.MouseOver();

            Console.ReadLine();
        }
    }

    public interface IPaintTool
    {
        void MouseOver();

        void MouseUp();
    }

    public class Pencil : IPaintTool
    {
        public void MouseOver()
        {
            Console.WriteLine("Show pencil icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a Line");
        }
    }

    public class circle : IPaintTool
    {
        public void MouseOver()
        {
            Console.WriteLine("Show circle icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Eraser : IPaintTool
    {
        public void MouseOver()
        {
            Console.WriteLine("Show an eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase the selected object");
        }
    }
}
