using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Juego
    {
        int total;
        List<int> tiradas = new List<int>();
        public void Tirar(int pinos)
        {
            tiradas.Add(pinos);
            if (pinos == 10)
                tiradas.Add(0);
        }

        public int Score()
        {
            for (int i = 0; i <= 19; i += 2)
            {
                if (tiradas[i] == 10)
                {
                    if (tiradas[i + 3] == 0)
                    {
                        total = total + tiradas[i] + tiradas[i + 1] + tiradas[i + 2] + tiradas[i + 4];
                    }
                    else
                    {
                        total = total + tiradas[i] + tiradas[i + 1] + tiradas[i + 2] + tiradas[i + 3];
                    }
                }
                else if (tiradas[i] + tiradas[i + 1] == 10)
                {
                    total = total + tiradas[i] + tiradas[i + 1] + tiradas[i + 2];                    
                }
                else
                {
                    total = total + tiradas[i] + tiradas[i + 1];
                }
            }
                
            return total;
        }

  
    }
}
