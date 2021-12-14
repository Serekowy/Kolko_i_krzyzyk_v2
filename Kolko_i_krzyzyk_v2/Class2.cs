using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolko_i_krzyzyk_v2
{
    class Class2
    {
        public static char Player = 'O';

        public static char[] Tab = new char[10];
        public static void FillBoard()
        {
            char number = '1';
            for (int i = 1; i < 10; i++)
            {
                Tab[i] = number;
                number++;
            }
        }
        public static bool CheckWin(char player)
        {
            for (int i = 1; i < 4; i++)
            {
                if (Class2.Tab[i] == player && Class2.Tab[i + 3] == player && Class2.Tab[i + 6] == player)
                {
                    return true;
                }
            }
            for (int i = 1; i < 8; i += 3)
            {
                if (Class2.Tab[i] == player && Class2.Tab[i + 1] == player && Class2.Tab[i + 2] == player)
                {
                    return true;
                }
            }

            if (Class2.Tab[1] == player && Class2.Tab[5] == player && Class2.Tab[9] == player)
            {
                return true;
            }

            if (Class2.Tab[3] == player && Class2.Tab[5] == player && Class2.Tab[7] == player)
            {
                return true;
            }

            return false;
        }
        public static bool CheckDraw()
        {
            int count = 0;
            for (int i = 1; i < 10; i++)
            {
                if (Class2.Tab[i] == 'X' || Class2.Tab[i] == 'O')
                {
                    count++;
                }
            }

            if (count == 9)
            {
                return true;
            }
            return false;
        }
        public static char ChangePlayer(char player)
        {
            if (player == 'O')
            {
                return 'X';
            }
            else
            {
                return 'O';
            }
        }
    }
}
