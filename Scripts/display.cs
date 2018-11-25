using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour {

    /* count which kind of blok is choosen
     * 
     * too many of them (20 types)
     * I woun't write all of them here
     * LOL
     */
    static private int blok;

    /* which side is choosen
     * 
     * 1 the front side (the side players can see)
     * 2 the back side
     * 
     * # some bloks may not have all sides
     */
    static private int side;

    /* which angle is choosen
     * 
     * 1 no change
     * 2 turn right for 90'
     * 3 upside down
     * 4 turn left for 90'
     * 
     * # some bloks may not have all angles
     */
    static private int angle;

    public display()
    {
        blok = 0;
        side = 1;
        angle = 1;
    }

    public display(int givenBlok, int givenSide, int givenAngle)
    {
        blok = givenBlok;
        side = givenSide;
        angle = givenAngle;
    }

    static public int getBlok()
    {
        return blok;
    }

    static public int getSide()
    {
        return side;
    }

    static public int getAngle()
    {
        return angle;
    }
    
    static public void setBlokByKey()
    {
        /*
        if (Input.GetMouseButtonDown(1))
        {
            switch (blok)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            bloks.setcanChange();
        }
        */
    }

    static public void setSideByKey()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            side += 1;
            if (side > 2)
            {
                side = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            side -= 1;
            if (side < 1)
            {
                side = 2;
            }
        }
    }

    static public void setAngleByKey()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            angle += 1;
            if (angle > 4)
            {
                angle = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            angle -= 1;
            if (angle < 1)
            {
                angle = 4;
            }
        }
    }

    static public void findBlok()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            switch (hit.collider.gameObject.name)
            {
                case "blok1":
                    blok = 1;
                    break;
                case "blok2":
                    blok = 2;
                    break;
                case "blok3":
                    blok = 3;
                    break;
                case "blok4":
                    blok = 4;
                    break;
                case "blok5":
                    blok = 5;
                    break;
                case "blok6":
                    blok = 6;
                    break;
                case "blok7":
                    blok = 7;
                    break;
                case "blok8":
                    blok = 8;
                    break;
                case "blok9":
                    blok = 9;
                    break;
                case "blok10":
                    blok = 10;
                    break;
                case "blok11":
                    blok = 11;
                    break;
                case "blok12":
                    blok = 12;
                    break;
                case "blok13":
                    blok = 3;
                    break;
                case "blok14":
                    blok = 14;
                    break;
                case "blok15":
                    blok = 15;
                    break;
                case "blok16":
                    blok = 16;
                    break;
                case "blok17":
                    blok = 17;
                    break;
                case "blok18":
                    blok = 18;
                    break;
                case "blok19":
                    blok = 19;
                    break;
                case "blok20":
                    blok = 20;
                    break;
                case "blok21":
                    blok = 21;
                    break;
                default:
                    break;
            }
        }
    }

}
