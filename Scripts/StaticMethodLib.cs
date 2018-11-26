using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMethodLib : MonoBehaviour
{

    public static char IntToChar(int i)
    {
        char c = ' ';

        if (i == 0)
        {
            c = '0';
        }
        else
        {
            c = (char)(i + 48);
        }

        return c;
    }

    public static string doOffset(string temp, int Xoffset, int Yoffset)
    {
        string newstring = "";

        int tempX = 0;
        int tempY = 0;

        tempX = (temp[5] - '0') * 10 + (temp[6] - '0');
        tempY = (temp[9] - '0') * 10 + (temp[10] - '0');

        tempX = tempX + Xoffset;
        tempY = tempY + Yoffset;

        newstring += "blok(";
        newstring += IntToChar(tempX / 10);
        newstring += IntToChar(tempX % 10);
        newstring += ")(";
        newstring += IntToChar(tempY / 10);
        newstring += IntToChar(tempY % 10);
        newstring += ")";

        return newstring;
    }

    public static coordinate stringTOcoordinate(string temp)
    {
        int tempX = (temp[5] - '0') * 10 + (temp[6] - '0');
        int tempY = (temp[9] - '0') * 10 + (temp[10] - '0');
        return new coordinate(tempX, tempY);
    }

    public static string coordinateTOstring(coordinate c)
    {
        string newstring = "";
        int tempX = c.getX();
        int tempY = c.getY();
        newstring += "blok(";
        newstring += IntToChar(tempX / 10);
        newstring += IntToChar(tempX % 10);
        newstring += ")(";
        newstring += IntToChar(tempY / 10);
        newstring += IntToChar(tempY % 10);
        newstring += ")";

        return newstring;
    }

}
