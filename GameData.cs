using System;
using System.Collections.Generic;

namespace CSharpTicTacToe
{
    class GameData
    {
        public List<List<int>> Board { get; } = new List<List<int>>();
        public GameData()
        {
            List<int> Line = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                Line.Add(0);
            }
            for (int i = 0; i < 3; i++)
            {
                Board.Add(Line);
            }
        }
        public GameData(int x, int y)
        {
            List<int> Line = new List<int>();
            for (int i = 0; i < x; i++)
            {
                Line.Add(0);
            }
            for (int i = 0; i < y; i++)
            {
                Board.Add(Line);
            }
        }
    }
}
