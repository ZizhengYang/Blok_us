using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok2
{
    public coordinate[] requireToChange(int side, int angle, coordinate co)
    {
        coordinate[] coo = new coordinate[5];
        coo[0] = co;
        for (int i = 1; i < 5; i++)
        {
            coo[i] = new coordinate();
        }
        return coo;
    }
}