﻿using System;



namespace UserInterface1
{


    public class GUI
    {
        protected static int origRow;
        protected static int origCol;



        public static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        public static void userint(int xstart, int xstop, int ystart, int ystop)
        {


            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;

            int i;
            for (i = xstart; i < xstop; i++)
            {
                WriteAt("-", i, ystart);
            }

            for (i = xstart; i < xstop; i++)
            {
                WriteAt("-", i, ystop);
            }

            for (i = ystart; i < ystop; i++)
            {
                WriteAt("|", xstart, i);
            }

            for (i = ystart; i < (ystop + 1); i++)
            {
                WriteAt("|", xstop, i);
            }
            for (i = xstart; i < xstop; i++)
            {
                WriteAt("-", i, ystart);
            }

            for (i = xstart; i < xstop; i++)
            {
                WriteAt("-", i, ystop);
            }

            for (i = ystart; i < ystop; i++)
            {
                WriteAt("|", xstart, i);
            }

            for (i = ystart; i < (ystop + 1); i++)
            {
                WriteAt("|", xstop, i);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(47, 6);
        }






    }
}



