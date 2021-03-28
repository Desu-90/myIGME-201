using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,,] zFunc = new double[41, 21, 3];
            double dX, dY, dZ;
            int nX, nY;
            nX = 0;
            for (dX = 0; dX<=4; dX += 0.1)
            {
                dX = Math.Round(dX, 1);
                nY = 0;
               for(dY = -1; dY <= 1; dY += 0.1)
                {
                    dY = Math.Round(dY, 1);

                    dY = Math.Round(dY, 1);

                    dZ = (4 * Math.Pow(dY, 3)) + (2 * Math.Pow(dX, 2)) - 8 * dX + 7;

                    dZ = Math.Round(dZ, 2);

                    zFunc[nX, nY, 0] = dX;

                    zFunc[nX, nY, 1] = dY;
                    
                    zFunc[nX, nY, 2] = dZ;

                    ++nY;

                }

                ++nX;

                Console.WriteLine(zFunc[1, 1, 1]);
}
            }
        }
    }
