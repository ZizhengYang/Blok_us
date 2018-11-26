using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok2
{
    public coordinate[] requireToChange(int side, int angle, coordinate co)
    {
        coordinate[] coo = new coordinate[5];
        coo[0] = co;
        if(side == 1 && angle == 1)
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, 1, 0);
        }
        else if (side == 1 && angle == 2)
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, 0, 1);
        }
        else if (side == 1 && angle == 3)
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, -1, 0);
        }
        else if (side == 1 && angle == 4)
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, 0, -1);
        }
        for (int i = 2; i < 5; i++)
        {
            coo[i] = new coordinate();
        }
        return coo;
    }
}