﻿void Distance(int x1, int y1, int z1, int x2, int y2,int z2)
{
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2));
}

Distance(3,6,8,2,1,-7);
Distance(7,-5,0,1,-1,9);