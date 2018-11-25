using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{

    /* count which is playing
     * 
     * 1: yellow round
     * 2: red round
     * 3: green round
     * 4: blue round
     */
    private static int player;

    /* count which kind of blok is choosen
     * 
     * too many of them (20 types)
     * I woun't write all of them here
     * LOL
     */
    private static int blok;

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

    private GameObject[] objects = new GameObject[5];

    void Awake()
    {
        player = 0;
        blok = 0;
        side = 1;
        angle = 1;
    }

    // Use this for initialization
    void Start()
    {
        player = 0;
        blok = 0;
        side = 1;
        angle = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

    }

    public void OnMouseEnter()
    {
        howToDisplay(main.blok, main.side, main.angle);
    }

    public void OnMouseExit()
    {
        howToHide(main.blok, main.side, main.angle);
    }

    private static void howToDisplay(int index, int side, int angle)
    {
        switch (index)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
            case 17:
                break;
            case 18:
                break;
            case 19:
                break;
            case 20:
                break;
            case 21:
                break;
            default:
                break;
        }
    }

    private static void howToHide(int index, int side, int angle)
    {
        switch (index)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
            case 17:
                break;
            case 18:
                break;
            case 19:
                break;
            case 20:
                break;
            case 21:
                break;
            default:
                break;
        }
    }

    public void findBlok()
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

    public static void determine()
    {
        
    }

    public static void setPlayerByKey()
    {
        if (main.player == 4)
        {
            main.player = 1;
        }
        else
        {
            main.player++;
        }
    }

    public static void setSideByKey(bool i)
    {
        if (i)
        {
            side += 1;
            if (side > 2)
            {
                side = 1;
            }
        }
        else
        {
            side -= 1;
            if (side < 1)
            {
                side = 2;
            }
        }
    }

    public static void setAngleByKey(bool i)
    {
        if (i)
        {
            angle += 1;
            if (angle > 4)
            {
                angle = 1;
            }
        }
        else
        {
            angle -= 1;
            if (angle < 1)
            {
                angle = 4;
            }
        }
    }

}
