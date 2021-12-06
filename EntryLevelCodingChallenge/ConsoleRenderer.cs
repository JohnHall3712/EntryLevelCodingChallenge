using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryLevelCodingChallenge
{
    static class ConsoleRenderer
    {
        static private string outputBuffer;
        static private char[,] inputBuffer;

        static private int winWidth;
        static private int winHeight;

        static private int cursorX;
        static private int cursorY;

        static private ConsoleColor listColor1;
        static private ConsoleColor listColor2;

        static private List<ConsoleColor> lineColors;

        static public void Init(int winWidth, int winHeight, ConsoleColor listColor1, ConsoleColor listColor2)
        {
            ConsoleRenderer.listColor1 = listColor1;
            ConsoleRenderer.listColor2 = listColor2;
            cursorX = 0;
            cursorY = 0;
            lineColors = new List<ConsoleColor>(winHeight);

            Console.CursorVisible = false;

            ResizeInputBuffer(winWidth, winHeight);
        }

        static public void ResizeInputBuffer(int width, int height)
        {
            winHeight = height;
            winWidth = width;

            Console.SetBufferSize(winWidth, winHeight);
            Console.SetWindowSize(winWidth, winHeight);

            inputBuffer = new char[winHeight, winWidth];
            ClearInputBuffer();
        }

        static public void ClearInputBuffer()
        {
            for (int y = 0; y < winHeight; y++) 
            {
                for (int x = 0; x < winWidth; x++)
                {
                    inputBuffer[y, x] = ' ';
                }
            }
        }

        static void SetAlternatingLineColors()
        {
            if (lineColors.Count == 0)
            {
                lineColors.Add(listColor1);
            }
            else if (lineColors[lineColors.Count-1] == listColor1)
            {
                lineColors.Add(listColor2);
            }
            else
            {
                lineColors.Add(listColor1);
            }
        }

        static public void WriteLine(string text, ConsoleColor color)
        {
            lineColors.Add(color);
            WriteLine(text.ToCharArray());            
        }

        static public void WriteLine(string text)
        {
            SetAlternatingLineColors();
            WriteLine(text.ToCharArray());
        }

        static public void WriteLine(char[] text)
        {
            WriteBuffer( cursorX, cursorY, text);
            cursorY++;
            cursorX = 0;
        }

        static private void WriteBuffer(int x, int y, char[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                cursorX = x + i;
                if (cursorX >= winWidth)
                {
                    cursorX = 0;
                    cursorY++;
                }

                if (cursorY < winHeight)
                {
                    inputBuffer[cursorY, cursorX] = text[i];
                }
            }
        }

        static public void ShowBuffer()
        {
            for (int y = 0; y < cursorY; y++) 
            {
                for (int x = 0; x < winWidth; x++)
                {
                    outputBuffer += inputBuffer[y, x];
                }
              
               Console.BackgroundColor = lineColors[y];
               Console.Write(outputBuffer);
               outputBuffer = "";
            }
            cursorX = 0;
            cursorY = 0;           
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
