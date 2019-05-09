using System;

namespace CampoMinado.Test
{
    internal class Jogo
    {
        public string[,] Grid { get; set; }
        public string[,] IniciarJogo(int tamanho)
        {
            Grid = new string[tamanho, tamanho];
            return Grid;
        }

        public void PreencherBomba(int y, int x)
        {
            Grid[y, x] = "*";
        }

        public void PreencherValores()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if(Grid[y,x] != "*")
                    {
                        Grid[y,x] =  VarrerEmVolta(y, x);
                    }
                }
            }
        }

        private string VarrerEmVolta(int y, int x)
        {
            var count = 0;

            if (y != 0 && x != 0 && Grid[y - 1, x - 1] == "*")
            {
                count++;
            }
            if(y != 0 && Grid[y-1,x] == "*")
            {
                count++;
            }
            if(x != 4 && y != 0 && Grid[y-1,x+1] == "*")
            {
                count++;
            }
            if(x != 0 && Grid[y,x-1] == "*")
            {
                count++;
            }
            if(x != 4 && Grid[y,x+1] == "*")
            {
                count++;
            }
            if(y != 4 && x != 0 && Grid[y+1,x-1] == "*")
            {
                count++;
            }
            if(y != 4 && Grid[y+1,x] == "*")
            {
                count++;
            }
            if(y != 4 && x != 4 && Grid[y+1,x+1] == "*")
            {
                count++;
            }

            if(count == 0)
            {
                return "0";
            }
            else
            {
                return "" + count;

            }        
        }
    }
}