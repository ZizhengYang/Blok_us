using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWay
{

    /* count which kind of blok is choosen
     * 
     * too many of them (20 types)
     * I woun't write all of them here
     * LOL
     */
    private static string blok;

    /* which side is choosen
     * 
     * 1 the front side (the side players can see)
     * 2 the back side
     * 
     * # some bloks may not have all sides
     */
    private static int side;

    /* which angle is choosen
     * 
     * 1 no change
     * 2 turn right for 90'
     * 3 upside down
     * 4 turn left for 90'
     * 
     * # some bloks may not have all angles
     */
    private static int angle;

    public DisplayWay()
    {
        blok = "blok0";
        side = 1;
        angle = 1;
    }

    public DisplayWay(string str)
    {
        blok = str;
        side = 1;
        angle = 1;
    }

    public string getBlok()
    {
        return blok;
    }

    public int getSide()
    {
        return side;
    }

    public int getAngle()
    {
        return angle;
    }

    public void setSide(int i)
    {
        side = i;
    }

    public void setAngle(int i)
    {
        angle = i;
    }

}