using System;
using System.Runtime.InteropServices;

namespace Calculator_boolean
{
    class Program
    {
        static int numoprators, numopratoreresult;
        static bool[,] table = new bool[8, (3 + numoprators+ numoprators+1)];
        static bool[,] incidetable()
        {
            bool[,] t = new bool[8, (3+numoprators+ numoprators+1)];
            t[0, 0] = false;t[0, 1] = false;t[0, 2] = false;
            t[1, 0] = false; t[1, 1] = false; t[1, 2] = true;
            t[2, 0] = false; t[2, 1] = true; t[2, 2] = false;
            t[3, 0] = false; t[3, 1] = true; t[3, 2] = true;
            t[4, 0] = true; t[4, 1] = false; t[4, 2] = false;
            t[5, 0] = true; t[5, 1] = false; t[5, 2] = true;
            t[6, 0] = true; t[6, 1] = true; t[6, 2] = false;
            t[7, 0] = true; t[7, 1] = true; t[7, 2] = true;


            return t;
        }
        static bool and(bool p,bool q)
        {
            bool res ;
            if (p == false && q == false)
                res = false;
            else if (p == false && q == true)
                res = false;
            else if (p == true && q == false)
                res = false;
            else res = true;
            return res;
        }
        static bool or(bool p, bool q)
        {
            bool res;
            if (p == false && q == false)
                res = false;
            else if (p == false && q == true)
                res = true;
            else if (p == true && q == false)
                res = true;
            else res = true;
            return res;
        }
        static bool xor(bool p, bool q)
        {
            bool res;
            if (p == false && q == false)
                res = false;
            else if (p == false && q == true)
                res = true;
            else if (p == true && q == false)
                res = true;
            else res = false;
            return res;
        }
        static bool onlyif(bool p, bool q)
        {
            bool res;
            if (p == false && q == false)
                res = true;
            else if (p == false && q == true)
                res = true;
            else if (p == true && q == false)
                res = false;
            else res = true;
            return res;
        }
        static bool ifandonlyif(bool p, bool q)
        {
            bool res;
            if (p == false && q == false)
                res = true;
            else if (p == false && q == true)
                res = false;
            else if (p == true && q == false)
                res = false;
            else res = true;
            return res;
        }
        static bool Schaeffers_stroke(bool p, bool q)
        {
            bool res;
            if (p == false && q == false)
                res = true;
            else if (p == false && q == true)
                res = true;
            else if (p == true && q == false)
                res = true;
            else res = false;
            return res;
        }
        static bool Pierces_arrow(bool p, bool q)
        {
            bool res;
            if (p == false && q == false)
                res = true;
            else if (p == false && q == true)
                res = false;
            else if (p == true && q == false)
                res = false;
            else res = false;
            return res;
        }
        static bool Not(bool p)
        {
            bool res;
            if (p == false)
                res = true;
            else
                res = false;
            return res;
        }

        static bool[,] calc(bool[,] t,char x  ,int numofop,int numexp, [Optional]char y)
        {
           
                    switch(numofop)
                    {
                    case 1:
                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = or(t[0, 0], t[0, 1]);
                        t[1, numexp] = or(t[1, 0], t[1, 1]);
                        t[2, numexp] = or(t[2, 0], t[2, 1]);
                        t[3, numexp] = or(t[3, 0], t[3, 1]);
                        t[4, numexp] = or(t[4, 0], t[4, 1]);
                        t[5, numexp] = or(t[5, 0], t[5, 1]);
                        t[6, numexp] = or(t[6, 0], t[6, 1]);
                        t[7, numexp] = or(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = or(t[0, 1], t[0, 0]);
                        t[1, numexp] = or(t[1, 1], t[1, 0]);
                        t[2, numexp] = or(t[2, 1], t[2, 0]);
                        t[3, numexp] = or(t[3, 1], t[3, 0]);
                        t[4, numexp] = or(t[4, 1], t[4, 0]);
                        t[5, numexp] = or(t[5, 1], t[5, 0]);
                        t[6, numexp] = or(t[6, 1], t[6, 0]);
                        t[7, numexp] = or(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = or(t[0, 0], t[0, 2]);
                        t[1, numexp] = or(t[1, 0], t[1, 2]);
                        t[2, numexp] = or(t[2, 0], t[2, 2]);
                        t[3, numexp] = or(t[3, 0], t[3, 2]);
                        t[4, numexp] = or(t[4, 0], t[4, 2]);
                        t[5, numexp] = or(t[5, 0], t[5, 2]);
                        t[6, numexp] = or(t[6, 0], t[6, 2]);
                        t[7, numexp] = or(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = or(t[0, 2], t[0, 0]);
                        t[1, numexp] = or(t[1, 2], t[1, 0]);
                        t[2, numexp] = or(t[2, 2], t[2, 0]);
                        t[3, numexp] = or(t[3, 2], t[3, 0]);
                        t[4, numexp] = or(t[4, 2], t[4, 0]);
                        t[5, numexp] = or(t[5, 2], t[5, 0]);
                        t[6, numexp] = or(t[6, 2], t[6, 0]);
                        t[7, numexp] = or(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = or(t[0, 2], t[0, 1]);
                        t[1, numexp] = or(t[1, 2], t[1, 1]);
                        t[2, numexp] = or(t[2, 2], t[2, 1]);
                        t[3, numexp] = or(t[3, 2], t[3, 1]);
                        t[4, numexp] = or(t[4, 2], t[4, 1]);
                        t[5, numexp] = or(t[5, 2], t[5, 1]);
                        t[6, numexp] = or(t[6, 2], t[6, 1]);
                        t[7, numexp] = or(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = or(t[0, 1], t[0, 2]);
                        t[1, numexp] = or(t[1, 1], t[1, 2]);
                        t[2, numexp] = or(t[2, 1], t[2, 2]);
                        t[3, numexp] = or(t[3, 1], t[3, 2]);
                        t[4, numexp] = or(t[4, 1], t[4, 2]);
                        t[5, numexp] = or(t[5, 1], t[5, 2]);
                        t[6, numexp] = or(t[6, 1], t[6, 2]);
                        t[7, numexp] = or(t[7, 1], t[7, 2]);
                    }
                    break;
                    case 2:
                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = and(t[0, 0], t[0, 1]);
                        t[1, numexp] = and(t[1, 0], t[1, 1]);
                        t[2, numexp] = and(t[2, 0], t[2, 1]);
                        t[3, numexp] = and(t[3, 0], t[3, 1]);
                        t[4, numexp] = and(t[4, 0], t[4, 1]);
                        t[5, numexp] = and(t[5, 0], t[5, 1]);
                        t[6, numexp] = and(t[6, 0], t[6, 1]);
                        t[7, numexp] = and(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = and(t[0, 1], t[0, 0]);
                        t[1, numexp] = and(t[1, 1], t[1, 0]);
                        t[2, numexp] = and(t[2, 1], t[2, 0]);
                        t[3, numexp] = and(t[3, 1], t[3, 0]);
                        t[4, numexp] = and(t[4, 1], t[4, 0]);
                        t[5, numexp] = and(t[5, 1], t[5, 0]);
                        t[6, numexp] = and(t[6, 1], t[6, 0]);
                        t[7, numexp] = and(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = and(t[0, 0], t[0, 2]);
                        t[1, numexp] = and(t[1, 0], t[1, 2]);
                        t[2, numexp] = and(t[2, 0], t[2, 2]);
                        t[3, numexp] = and(t[3, 0], t[3, 2]);
                        t[4, numexp] = and(t[4, 0], t[4, 2]);
                        t[5, numexp] = and(t[5, 0], t[5, 2]);
                        t[6, numexp] = and(t[6, 0], t[6, 2]);
                        t[7, numexp] = and(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = and(t[0, 2], t[0, 0]);
                        t[1, numexp] = and(t[1, 2], t[1, 0]);
                        t[2, numexp] = and(t[2, 2], t[2, 0]);
                        t[3, numexp] = and(t[3, 2], t[3, 0]);
                        t[4, numexp] = and(t[4, 2], t[4, 0]);
                        t[5, numexp] = and(t[5, 2], t[5, 0]);
                        t[6, numexp] = and(t[6, 2], t[6, 0]);
                        t[7, numexp] = and(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = and(t[0, 2], t[0, 1]);
                        t[1, numexp] = and(t[1, 2], t[1, 1]);
                        t[2, numexp] = and(t[2, 2], t[2, 1]);
                        t[3, numexp] = and(t[3, 2], t[3, 1]);
                        t[4, numexp] = and(t[4, 2], t[4, 1]);
                        t[5, numexp] = and(t[5, 2], t[5, 1]);
                        t[6, numexp] = and(t[6, 2], t[6, 1]);
                        t[7, numexp] = and(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = and(t[0, 1], t[0, 2]);
                        t[1, numexp] = and(t[1, 1], t[1, 2]);
                        t[2, numexp] = and(t[2, 1], t[2, 2]);
                        t[3, numexp] = and(t[3, 1], t[3, 2]);
                        t[4, numexp] = and(t[4, 1], t[4, 2]);
                        t[5, numexp] = and(t[5, 1], t[5, 2]);
                        t[6, numexp] = and(t[6, 1], t[6, 2]);
                        t[7, numexp] = and(t[7, 1], t[7, 2]);
                    }
                    break;
                    case 3:
                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = xor(t[0, 0], t[0, 1]);
                        t[1, numexp] = xor(t[1, 0], t[1, 1]);
                        t[2, numexp] = xor(t[2, 0], t[2, 1]);
                        t[3, numexp] = xor(t[3, 0], t[3, 1]);
                        t[4, numexp] = xor(t[4, 0], t[4, 1]);
                        t[5, numexp] = xor(t[5, 0], t[5, 1]);
                        t[6, numexp] = xor(t[6, 0], t[6, 1]);
                        t[7, numexp] = xor(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = xor(t[0, 1], t[0, 0]);
                        t[1, numexp] = xor(t[1, 1], t[1, 0]);
                        t[2, numexp] = xor(t[2, 1], t[2, 0]);
                        t[3, numexp] = xor(t[3, 1], t[3, 0]);
                        t[4, numexp] = xor(t[4, 1], t[4, 0]);
                        t[5, numexp] = xor(t[5, 1], t[5, 0]);
                        t[6, numexp] = xor(t[6, 1], t[6, 0]);
                        t[7, numexp] = xor(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = xor(t[0, 0], t[0, 2]);
                        t[1, numexp] = xor(t[1, 0], t[1, 2]);
                        t[2, numexp] = xor(t[2, 0], t[2, 2]);
                        t[3, numexp] = xor(t[3, 0], t[3, 2]);
                        t[4, numexp] = xor(t[4, 0], t[4, 2]);
                        t[5, numexp] = xor(t[5, 0], t[5, 2]);
                        t[6, numexp] = xor(t[6, 0], t[6, 2]);
                        t[7, numexp] = xor(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = xor(t[0, 2], t[0, 0]);
                        t[1, numexp] = xor(t[1, 2], t[1, 0]);
                        t[2, numexp] = xor(t[2, 2], t[2, 0]);
                        t[3, numexp] = xor(t[3, 2], t[3, 0]);
                        t[4, numexp] = xor(t[4, 2], t[4, 0]);
                        t[5, numexp] = xor(t[5, 2], t[5, 0]);
                        t[6, numexp] = xor(t[6, 2], t[6, 0]);
                        t[7, numexp] = xor(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = xor(t[0, 2], t[0, 1]);
                        t[1, numexp] = xor(t[1, 2], t[1, 1]);
                        t[2, numexp] = xor(t[2, 2], t[2, 1]);
                        t[3, numexp] = xor(t[3, 2], t[3, 1]);
                        t[4, numexp] = xor(t[4, 2], t[4, 1]);
                        t[5, numexp] = xor(t[5, 2], t[5, 1]);
                        t[6, numexp] = xor(t[6, 2], t[6, 1]);
                        t[7, numexp] = xor(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = xor(t[0, 1], t[0, 2]);
                        t[1, numexp] = xor(t[1, 1], t[1, 2]);
                        t[2, numexp] = xor(t[2, 1], t[2, 2]);
                        t[3, numexp] = xor(t[3, 1], t[3, 2]);
                        t[4, numexp] = xor(t[4, 1], t[4, 2]);
                        t[5, numexp] = xor(t[5, 1], t[5, 2]);
                        t[6, numexp] = xor(t[6, 1], t[6, 2]);
                        t[7, numexp] = xor(t[7, 1], t[7, 2]);
                    }
                    break;
                case 4:

                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = onlyif(t[0, 0], t[0, 1]);
                        t[1, numexp] = onlyif(t[1, 0], t[1, 1]);
                        t[2, numexp] = onlyif(t[2, 0], t[2, 1]);
                        t[3, numexp] = onlyif(t[3, 0], t[3, 1]);
                        t[4, numexp] = onlyif(t[4, 0], t[4, 1]);
                        t[5, numexp] = onlyif(t[5, 0], t[5, 1]);
                        t[6, numexp] = onlyif(t[6, 0], t[6, 1]);
                        t[7, numexp] = onlyif(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = onlyif(t[0, 1], t[0, 0]);
                        t[1, numexp] = onlyif(t[1, 1], t[1, 0]);
                        t[2, numexp] = onlyif(t[2, 1], t[2, 0]);
                        t[3, numexp] = onlyif(t[3, 1], t[3, 0]);
                        t[4, numexp] = onlyif(t[4, 1], t[4, 0]);
                        t[5, numexp] = onlyif(t[5, 1], t[5, 0]);
                        t[6, numexp] = onlyif(t[6, 1], t[6, 0]);
                        t[7, numexp] = onlyif(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = onlyif(t[0, 0], t[0, 2]);
                        t[1, numexp] = onlyif(t[1, 0], t[1, 2]);
                        t[2, numexp] = onlyif(t[2, 0], t[2, 2]);
                        t[3, numexp] = onlyif(t[3, 0], t[3, 2]);
                        t[4, numexp] = onlyif(t[4, 0], t[4, 2]);
                        t[5, numexp] = onlyif(t[5, 0], t[5, 2]);
                        t[6, numexp] = onlyif(t[6, 0], t[6, 2]);
                        t[7, numexp] = onlyif(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = onlyif(t[0, 2], t[0, 0]);
                        t[1, numexp] = onlyif(t[1, 2], t[1, 0]);
                        t[2, numexp] = onlyif(t[2, 2], t[2, 0]);
                        t[3, numexp] = onlyif(t[3, 2], t[3, 0]);
                        t[4, numexp] = onlyif(t[4, 2], t[4, 0]);
                        t[5, numexp] = onlyif(t[5, 2], t[5, 0]);
                        t[6, numexp] = onlyif(t[6, 2], t[6, 0]);
                        t[7, numexp] = onlyif(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = onlyif(t[0, 2], t[0, 1]);
                        t[1, numexp] = onlyif(t[1, 2], t[1, 1]);
                        t[2, numexp] = onlyif(t[2, 2], t[2, 1]);
                        t[3, numexp] = onlyif(t[3, 2], t[3, 1]);
                        t[4, numexp] = onlyif(t[4, 2], t[4, 1]);
                        t[5, numexp] = onlyif(t[5, 2], t[5, 1]);
                        t[6, numexp] = onlyif(t[6, 2], t[6, 1]);
                        t[7, numexp] = onlyif(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = onlyif(t[0, 1], t[0, 2]);
                        t[1, numexp] = onlyif(t[1, 1], t[1, 2]);
                        t[2, numexp] = onlyif(t[2, 1], t[2, 2]);
                        t[3, numexp] = onlyif(t[3, 1], t[3, 2]);
                        t[4, numexp] = onlyif(t[4, 1], t[4, 2]);
                        t[5, numexp] = onlyif(t[5, 1], t[5, 2]);
                        t[6, numexp] = onlyif(t[6, 1], t[6, 2]);
                        t[7, numexp] = onlyif(t[7, 1], t[7, 2]);
                    }
                    break;
                case 5:
                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = ifandonlyif(t[0, 0], t[0, 1]);
                        t[1, numexp] = ifandonlyif(t[1, 0], t[1, 1]);
                        t[2, numexp] = ifandonlyif(t[2, 0], t[2, 1]);
                        t[3, numexp] = ifandonlyif(t[3, 0], t[3, 1]);
                        t[4, numexp] = ifandonlyif(t[4, 0], t[4, 1]);
                        t[5, numexp] = ifandonlyif(t[5, 0], t[5, 1]);
                        t[6, numexp] = ifandonlyif(t[6, 0], t[6, 1]);
                        t[7, numexp] = ifandonlyif(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = ifandonlyif(t[0, 1], t[0, 0]);
                        t[1, numexp] = ifandonlyif(t[1, 1], t[1, 0]);
                        t[2, numexp] = ifandonlyif(t[2, 1], t[2, 0]);
                        t[3, numexp] = ifandonlyif(t[3, 1], t[3, 0]);
                        t[4, numexp] = ifandonlyif(t[4, 1], t[4, 0]);
                        t[5, numexp] = ifandonlyif(t[5, 1], t[5, 0]);
                        t[6, numexp] = ifandonlyif(t[6, 1], t[6, 0]);
                        t[7, numexp] = ifandonlyif(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = ifandonlyif(t[0, 0], t[0, 2]);
                        t[1, numexp] = ifandonlyif(t[1, 0], t[1, 2]);
                        t[2, numexp] = ifandonlyif(t[2, 0], t[2, 2]);
                        t[3, numexp] = ifandonlyif(t[3, 0], t[3, 2]);
                        t[4, numexp] = ifandonlyif(t[4, 0], t[4, 2]);
                        t[5, numexp] = ifandonlyif(t[5, 0], t[5, 2]);
                        t[6, numexp] = ifandonlyif(t[6, 0], t[6, 2]);
                        t[7, numexp] = ifandonlyif(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = ifandonlyif(t[0, 2], t[0, 0]);
                        t[1, numexp] = ifandonlyif(t[1, 2], t[1, 0]);
                        t[2, numexp] = ifandonlyif(t[2, 2], t[2, 0]);
                        t[3, numexp] = ifandonlyif(t[3, 2], t[3, 0]);
                        t[4, numexp] = ifandonlyif(t[4, 2], t[4, 0]);
                        t[5, numexp] = ifandonlyif(t[5, 2], t[5, 0]);
                        t[6, numexp] = ifandonlyif(t[6, 2], t[6, 0]);
                        t[7, numexp] = ifandonlyif(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = ifandonlyif(t[0, 2], t[0, 1]);
                        t[1, numexp] = ifandonlyif(t[1, 2], t[1, 1]);
                        t[2, numexp] = ifandonlyif(t[2, 2], t[2, 1]);
                        t[3, numexp] = ifandonlyif(t[3, 2], t[3, 1]);
                        t[4, numexp] = ifandonlyif(t[4, 2], t[4, 1]);
                        t[5, numexp] = ifandonlyif(t[5, 2], t[5, 1]);
                        t[6, numexp] = ifandonlyif(t[6, 2], t[6, 1]);
                        t[7, numexp] = ifandonlyif(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = ifandonlyif(t[0, 1], t[0, 2]);
                        t[1, numexp] = ifandonlyif(t[1, 1], t[1, 2]);
                        t[2, numexp] = ifandonlyif(t[2, 1], t[2, 2]);
                        t[3, numexp] = ifandonlyif(t[3, 1], t[3, 2]);
                        t[4, numexp] = ifandonlyif(t[4, 1], t[4, 2]);
                        t[5, numexp] = ifandonlyif(t[5, 1], t[5, 2]);
                        t[6, numexp] = ifandonlyif(t[6, 1], t[6, 2]);
                        t[7, numexp] = ifandonlyif(t[7, 1], t[7, 2]);
                    }

                    break;
                case 6:
                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = Schaeffers_stroke(t[0, 0], t[0, 1]);
                        t[1, numexp] = Schaeffers_stroke(t[1, 0], t[1, 1]);
                        t[2, numexp] = Schaeffers_stroke(t[2, 0], t[2, 1]);
                        t[3, numexp] = Schaeffers_stroke(t[3, 0], t[3, 1]);
                        t[4, numexp] = Schaeffers_stroke(t[4, 0], t[4, 1]);
                        t[5, numexp] = Schaeffers_stroke(t[5, 0], t[5, 1]);
                        t[6, numexp] = Schaeffers_stroke(t[6, 0], t[6, 1]);
                        t[7, numexp] = Schaeffers_stroke(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = Schaeffers_stroke(t[0, 1], t[0, 0]);
                        t[1, numexp] = Schaeffers_stroke(t[1, 1], t[1, 0]);
                        t[2, numexp] = Schaeffers_stroke(t[2, 1], t[2, 0]);
                        t[3, numexp] = Schaeffers_stroke(t[3, 1], t[3, 0]);
                        t[4, numexp] = Schaeffers_stroke(t[4, 1], t[4, 0]);
                        t[5, numexp] = Schaeffers_stroke(t[5, 1], t[5, 0]);
                        t[6, numexp] = Schaeffers_stroke(t[6, 1], t[6, 0]);
                        t[7, numexp] = Schaeffers_stroke(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = Schaeffers_stroke(t[0, 0], t[0, 2]);
                        t[1, numexp] = Schaeffers_stroke(t[1, 0], t[1, 2]);
                        t[2, numexp] = Schaeffers_stroke(t[2, 0], t[2, 2]);
                        t[3, numexp] = Schaeffers_stroke(t[3, 0], t[3, 2]);
                        t[4, numexp] = Schaeffers_stroke(t[4, 0], t[4, 2]);
                        t[5, numexp] = Schaeffers_stroke(t[5, 0], t[5, 2]);
                        t[6, numexp] = Schaeffers_stroke(t[6, 0], t[6, 2]);
                        t[7, numexp] = Schaeffers_stroke(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = Schaeffers_stroke(t[0, 2], t[0, 0]);
                        t[1, numexp] = Schaeffers_stroke(t[1, 2], t[1, 0]);
                        t[2, numexp] = Schaeffers_stroke(t[2, 2], t[2, 0]);
                        t[3, numexp] = Schaeffers_stroke(t[3, 2], t[3, 0]);
                        t[4, numexp] = Schaeffers_stroke(t[4, 2], t[4, 0]);
                        t[5, numexp] = Schaeffers_stroke(t[5, 2], t[5, 0]);
                        t[6, numexp] = Schaeffers_stroke(t[6, 2], t[6, 0]);
                        t[7, numexp] = Schaeffers_stroke(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = Schaeffers_stroke(t[0, 2], t[0, 1]);
                        t[1, numexp] = Schaeffers_stroke(t[1, 2], t[1, 1]);
                        t[2, numexp] = Schaeffers_stroke(t[2, 2], t[2, 1]);
                        t[3, numexp] = Schaeffers_stroke(t[3, 2], t[3, 1]);
                        t[4, numexp] = Schaeffers_stroke(t[4, 2], t[4, 1]);
                        t[5, numexp] = Schaeffers_stroke(t[5, 2], t[5, 1]);
                        t[6, numexp] = Schaeffers_stroke(t[6, 2], t[6, 1]);
                        t[7, numexp] = Schaeffers_stroke(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = Schaeffers_stroke(t[0, 1], t[0, 2]);
                        t[1, numexp] = Schaeffers_stroke(t[1, 1], t[1, 2]);
                        t[2, numexp] = Schaeffers_stroke(t[2, 1], t[2, 2]);
                        t[3, numexp] = Schaeffers_stroke(t[3, 1], t[3, 2]);
                        t[4, numexp] = Schaeffers_stroke(t[4, 1], t[4, 2]);
                        t[5, numexp] = Schaeffers_stroke(t[5, 1], t[5, 2]);
                        t[6, numexp] = Schaeffers_stroke(t[6, 1], t[6, 2]);
                        t[7, numexp] = Schaeffers_stroke(t[7, 1], t[7, 2]);
                    }
                    break;
                case 7:
                    if (x == 'p' && y == 'q')
                    {
                        t[0, numexp] = Pierces_arrow(t[0, 0], t[0, 1]);
                        t[1, numexp] = Pierces_arrow(t[1, 0], t[1, 1]);
                        t[2, numexp] = Pierces_arrow(t[2, 0], t[2, 1]);
                        t[3, numexp] = Pierces_arrow(t[3, 0], t[3, 1]);
                        t[4, numexp] = Pierces_arrow(t[4, 0], t[4, 1]);
                        t[5, numexp] = Pierces_arrow(t[5, 0], t[5, 1]);
                        t[6, numexp] = Pierces_arrow(t[6, 0], t[6, 1]);
                        t[7, numexp] = Pierces_arrow(t[7, 0], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'p')
                    {
                        t[0, numexp] = Pierces_arrow(t[0, 1], t[0, 0]);
                        t[1, numexp] = Pierces_arrow(t[1, 1], t[1, 0]);
                        t[2, numexp] = Pierces_arrow(t[2, 1], t[2, 0]);
                        t[3, numexp] = Pierces_arrow(t[3, 1], t[3, 0]);
                        t[4, numexp] = Pierces_arrow(t[4, 1], t[4, 0]);
                        t[5, numexp] = Pierces_arrow(t[5, 1], t[5, 0]);
                        t[6, numexp] = Pierces_arrow(t[6, 1], t[6, 0]);
                        t[7, numexp] = Pierces_arrow(t[7, 1], t[7, 0]);

                    }
                    else if (x == 'p' && y == 'r')
                    {
                        t[0, numexp] = Pierces_arrow(t[0, 0], t[0, 2]);
                        t[1, numexp] = Pierces_arrow(t[1, 0], t[1, 2]);
                        t[2, numexp] = Pierces_arrow(t[2, 0], t[2, 2]);
                        t[3, numexp] = Pierces_arrow(t[3, 0], t[3, 2]);
                        t[4, numexp] = Pierces_arrow(t[4, 0], t[4, 2]);
                        t[5, numexp] = Pierces_arrow(t[5, 0], t[5, 2]);
                        t[6, numexp] = Pierces_arrow(t[6, 0], t[6, 2]);
                        t[7, numexp] = Pierces_arrow(t[7, 0], t[7, 2]);

                    }
                    else if (x == 'r' && y == 'p')
                    {
                        t[0, numexp] = Pierces_arrow(t[0, 2], t[0, 0]);
                        t[1, numexp] = Pierces_arrow(t[1, 2], t[1, 0]);
                        t[2, numexp] = Pierces_arrow(t[2, 2], t[2, 0]);
                        t[3, numexp] = Pierces_arrow(t[3, 2], t[3, 0]);
                        t[4, numexp] = Pierces_arrow(t[4, 2], t[4, 0]);
                        t[5, numexp] = Pierces_arrow(t[5, 2], t[5, 0]);
                        t[6, numexp] = Pierces_arrow(t[6, 2], t[6, 0]);
                        t[7, numexp] = Pierces_arrow(t[7, 2], t[7, 0]);
                    }
                    else if (x == 'r' && y == 'q')
                    {
                        t[0, numexp] = Pierces_arrow(t[0, 2], t[0, 1]);
                        t[1, numexp] = Pierces_arrow(t[1, 2], t[1, 1]);
                        t[2, numexp] = Pierces_arrow(t[2, 2], t[2, 1]);
                        t[3, numexp] = Pierces_arrow(t[3, 2], t[3, 1]);
                        t[4, numexp] = Pierces_arrow(t[4, 2], t[4, 1]);
                        t[5, numexp] = Pierces_arrow(t[5, 2], t[5, 1]);
                        t[6, numexp] = Pierces_arrow(t[6, 2], t[6, 1]);
                        t[7, numexp] = Pierces_arrow(t[7, 2], t[7, 1]);
                    }
                    else if (x == 'q' && y == 'r')
                    {
                        t[0, numexp] = Pierces_arrow(t[0, 1], t[0, 2]);
                        t[1, numexp] = Pierces_arrow(t[1, 1], t[1, 2]);
                        t[2, numexp] = Pierces_arrow(t[2, 1], t[2, 2]);
                        t[3, numexp] = Pierces_arrow(t[3, 1], t[3, 2]);
                        t[4, numexp] = Pierces_arrow(t[4, 1], t[4, 2]);
                        t[5, numexp] = Pierces_arrow(t[5, 1], t[5, 2]);
                        t[6, numexp] = Pierces_arrow(t[6, 1], t[6, 2]);
                        t[7, numexp] = Pierces_arrow(t[7, 1], t[7, 2]);
                    }
                    break;
                case 8:
                    if(x =='p')
                    {
                        t[0, numexp] = Not(t[0, 0]);
                        t[1, numexp] = Not(t[1, 0]);
                        t[2, numexp] = Not(t[2, 0]);
                        t[3, numexp] = Not(t[3, 0]);
                        t[4, numexp] = Not(t[4, 0]);
                        t[5, numexp] = Not(t[5, 0]);
                        t[6, numexp] = Not(t[6, 0]);
                        t[7, numexp] = Not(t[7, 0]);
                    }
                    else if(x=='q')
                    {
                        t[0, numexp] = Not(t[0, 1]);
                        t[1, numexp] = Not(t[1, 1]);
                        t[2, numexp] = Not(t[2, 1]);
                        t[3, numexp] = Not(t[3, 1]);
                        t[4, numexp] = Not(t[4, 1]);
                        t[5, numexp] = Not(t[5, 1]);
                        t[6, numexp] = Not(t[6, 1]);
                        t[7, numexp] = Not(t[7, 1]);
                    }
                    else if(x == 'r')
                    {
                        t[0, numexp] = Not(t[0, 2]);
                        t[1, numexp] = Not(t[1, 2]);
                        t[2, numexp] = Not(t[2, 2]);
                        t[3, numexp] = Not(t[3, 2]);
                        t[4, numexp] = Not(t[4, 2]);
                        t[5, numexp] = Not(t[5, 2]);
                        t[6, numexp] = Not(t[6, 2]);
                        t[7, numexp] = Not(t[7, 2]);
                    }
                    break;
                    }
              
            

            return t;
        }

        static bool[,] calcResult(bool[,] t,int count, int numofop, int numexp1, [Optional]int numexp2)
        {
            int numexp = 3 + numoprators+count;
            switch (numofop)
            {
                case 1:

                    t[0, numexp] = or(t[0, numexp1], t[0, numexp2]);
                    t[1, numexp] = or(t[1, numexp1], t[1, numexp2]);
                    t[2, numexp] = or(t[2, numexp1], t[2, numexp2]);
                    t[3, numexp] = or(t[3, numexp1], t[3, numexp2]);
                    t[4, numexp] = or(t[4, numexp1], t[4, numexp2]);
                    t[5, numexp] = or(t[5, numexp1], t[5, numexp2]);
                    t[6, numexp] = or(t[6, numexp1], t[6, numexp2]);
                    t[7, numexp] = or(t[7, numexp1], t[7, numexp2]);


                    break;
                case 2:
                   
                        t[0, numexp] = and(t[0, numexp1], t[0, numexp2]);
                        t[1, numexp] = and(t[1, numexp1], t[1, numexp2]);
                        t[2, numexp] = and(t[2, numexp1], t[2, numexp2]);
                        t[3, numexp] = and(t[3, numexp1], t[3, numexp2]);
                        t[4, numexp] = and(t[4, numexp1], t[4, numexp2]);
                        t[5, numexp] = and(t[5, numexp1], t[5, numexp2]);
                        t[6, numexp] = and(t[6, numexp1], t[6, numexp2]);
                        t[7, numexp] = and(t[7, numexp1], t[7, numexp2]);
                   
                    break;
                case 3:

                    t[0, numexp] = xor(t[0, numexp1], t[0, numexp2]);
                    t[1, numexp] = xor(t[1, numexp1], t[1, numexp2]);
                    t[2, numexp] = xor(t[2, numexp1], t[2, numexp2]);
                    t[3, numexp] = xor(t[3, numexp1], t[3, numexp2]);
                    t[4, numexp] = xor(t[4, numexp1], t[4, numexp2]);
                    t[5, numexp] = xor(t[5, numexp1], t[5, numexp2]);
                    t[6, numexp] = xor(t[6, numexp1], t[6, numexp2]);
                    t[7, numexp] = xor(t[7, numexp1], t[7, numexp2]);

                    break;
                case 4:

                    t[0, numexp] = onlyif(t[0, numexp1], t[0, numexp2]);
                    t[1, numexp] = onlyif(t[1, numexp1], t[1, numexp2]);
                    t[2, numexp] = onlyif(t[2, numexp1], t[2, numexp2]);
                    t[3, numexp] = onlyif(t[3, numexp1], t[3, numexp2]);
                    t[4, numexp] = onlyif(t[4, numexp1], t[4, numexp2]);
                    t[5, numexp] = onlyif(t[5, numexp1], t[5, numexp2]);
                    t[6, numexp] = onlyif(t[6, numexp1], t[6, numexp2]);
                    t[7, numexp] = onlyif(t[7, numexp1], t[7, numexp2]);

                    break;
                case 5:
                    t[0, numexp] = ifandonlyif(t[0, numexp1], t[0, numexp2]);
                    t[1, numexp] = ifandonlyif(t[1, numexp1], t[1, numexp2]);
                    t[2, numexp] = ifandonlyif(t[2, numexp1], t[2, numexp2]);
                    t[3, numexp] = ifandonlyif(t[3, numexp1], t[3, numexp2]);
                    t[4, numexp] = ifandonlyif(t[4, numexp1], t[4, numexp2]);
                    t[5, numexp] = ifandonlyif(t[5, numexp1], t[5, numexp2]);
                    t[6, numexp] = ifandonlyif(t[6, numexp1], t[6, numexp2]);
                    t[7, numexp] = ifandonlyif(t[7, numexp1], t[7, numexp2]);



                    break;
                case 6:
                    t[0, numexp] = Schaeffers_stroke(t[0, numexp1], t[0, numexp2]);
                    t[1, numexp] = Schaeffers_stroke(t[1, numexp1], t[1, numexp2]);
                    t[2, numexp] = Schaeffers_stroke(t[2, numexp1], t[2, numexp2]);
                    t[3, numexp] = Schaeffers_stroke(t[3, numexp1], t[3, numexp2]);
                    t[4, numexp] = Schaeffers_stroke(t[4, numexp1], t[4, numexp2]);
                    t[5, numexp] = Schaeffers_stroke(t[5, numexp1], t[5, numexp2]);
                    t[6, numexp] = Schaeffers_stroke(t[6, numexp1], t[6, numexp2]);
                    t[7, numexp] = Schaeffers_stroke(t[7, numexp1], t[7, numexp2]);
                    break;
                case 7:
                    t[0, numexp] = Pierces_arrow(t[0, numexp1], t[0, numexp2]);
                    t[1, numexp] = Pierces_arrow(t[1, numexp1], t[1, numexp2]);
                    t[2, numexp] = Pierces_arrow(t[2, numexp1], t[2, numexp2]);
                    t[3, numexp] = Pierces_arrow(t[3, numexp1], t[3, numexp2]);
                    t[4, numexp] = Pierces_arrow(t[4, numexp1], t[4, numexp2]);
                    t[5, numexp] = Pierces_arrow(t[5, numexp1], t[5, numexp2]);
                    t[6, numexp] = Pierces_arrow(t[6, numexp1], t[6, numexp2]);
                    t[7, numexp] = Pierces_arrow(t[7, numexp1], t[7, numexp2]);
                    break;
                case 8:

                    t[0, numexp] = Not(t[0, numexp1]);
                    t[1, numexp] = Not(t[1, numexp1]);
                    t[2, numexp] = Not(t[2, numexp1]);
                    t[3, numexp] = Not(t[3, numexp1]);
                    t[4, numexp] = Not(t[4, numexp1]);
                    t[5, numexp] = Not(t[5, numexp1]);
                    t[6, numexp] = Not(t[6, numexp1]);
                    t[7, numexp] = Not(t[7, numexp1]);
                    break;
               
            }

            return t;
        }
        static void Main(string[] args)
        {
            char p, q;
            int op, numexp1, numexp2;
            Console.WriteLine("\t Calculator Boolean ");
            Console.WriteLine("Enter number oprators");
            numoprators = int.Parse(Console.ReadLine());
            table = incidetable();
            for (int i=0;i<numoprators;i++)
            { 
                Console.WriteLine("Enter first proof p , q or r");
                p = char.Parse(Console.ReadLine());
                Console.WriteLine("1. or => or");
                Console.WriteLine("2. & => and");
                Console.WriteLine("3. Xor => xor");
                Console.WriteLine("4. -> => if");
                Console.WriteLine("5. <-> => iff");
                Console.WriteLine("6. | => sch");
                Console.WriteLine("7. Pierces => pr");
                Console.WriteLine("8. Not => Not");
                Console.WriteLine("Enter oprator");
                op = int.Parse(Console.ReadLine());  
                if (op == 8)
                    table = calc(table, p, op, i + 3);                                 
                else
                {
                    Console.WriteLine("Enter second proof p , q or r");
                    q = char.Parse(Console.ReadLine());
                    table = calc(table, p, op, i + 3, q);
                }   
            }
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3 + numoprators; j++)
                {
                    if (table[i, j] == false)
                    Console.Write("|  " + 0 + " ");
                    else
                        Console.Write("|  " + 1 + " ");
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
            }
//-------------------------------------------------------Result------------------------------------------------------------------------
            Console.WriteLine("Enter number oprators for result");
            numopratoreresult = int.Parse(Console.ReadLine());
            for (int i = 0; i < numopratoreresult; i++)
            {
                Console.WriteLine("For Result Enter number first column ");
                numexp1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter oprators");
                Console.WriteLine("1. or => or");
                Console.WriteLine("2. & => and");
                Console.WriteLine("3. Xor => xor");
                Console.WriteLine("4. -> => if");
                Console.WriteLine("5. <-> => iff");
                Console.WriteLine("6. | => sch");
                Console.WriteLine("7. Pierces => pr");
                Console.WriteLine("8. Not => Not");
                Console.WriteLine("Enter oprator");
                op = int.Parse(Console.ReadLine());
                if (op == 8)
                    table = calcResult(table,i, op, numexp1);
                else
                {
                    Console.WriteLine("For Result Enter number second column ");
                    numexp2 = int.Parse(Console.ReadLine());
                    table = calcResult(table,i, op, numexp1, numexp2);
                }   
            }
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j <( 3 + numopratoreresult + numoprators); j++)
                {
                    if (table[i, j] == false)
                        Console.Write("|  " + 0 + " ");
                    else
                        Console.Write("|  " + 1 + " ");                  
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
