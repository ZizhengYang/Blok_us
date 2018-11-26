using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    static DisplayBlok[,] b = new DisplayBlok[20, 20];
    static coordinate pointedBlok;
    // static Player[] players = new Player[4];
    static Player player;
    static DisplayWay dis = new DisplayWay();
    static coordinate co = new coordinate();

    blok1 b1 = new blok1();
    blok2 b2 = new blok2();
    blok3 b3 = new blok3();
    blok4 b4 = new blok4();
    blok5 b5 = new blok5();
    blok6 b6 = new blok6();
    blok7 b7 = new blok7();
    blok8 b8 = new blok8();
    blok9 b9 = new blok9();
    blok10 b10 = new blok10();
    blok11 b11 = new blok11();
    blok12 b12 = new blok12();
    blok13 b13 = new blok13();
    blok14 b14 = new blok14();
    blok15 b15 = new blok15();
    blok16 b16 = new blok16();
    blok17 b17 = new blok17();
    blok18 b18 = new blok18();
    blok19 b19 = new blok19();
    blok20 b20 = new blok20();
    blok21 b21 = new blok21();

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                b[i, j] = new DisplayBlok();
            }
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name.Length > 5)
            {
                if (hit.transform.name.Substring(0, 5).Equals("blok("))
                {
                    // Debug.Log(hit.transform.name.Substring(0, 5));
                    if (StaticMethodLib.stringTOcoordinate(hit.transform.name).getX() == co.getX()
                        && StaticMethodLib.stringTOcoordinate(hit.transform.name).getY() == co.getY())
                    {

                    }
                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                if (!b[i, j].getFix())
                                {
                                    b[i, j].setShow(false);
                                }
                            }
                        }
                        co = StaticMethodLib.stringTOcoordinate(hit.transform.name);
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;

            if (Physics.Raycast(ray2, out hit2))
            {
                // Debug.Log(hit.transform.name);
                dis = Main.ResetDisplayWay(hit2.transform.name);
                // blokAbstract.setblokName(hit.transform.name);
            }

        }

        coordinate[] coo = new coordinate[5];
        coo = findBlok(dis.getBlok(), dis.getSide(), dis.getAngle(), co);

        for(int i = 0; i < coo.Length; i++)
        {
            int x = coo[i].getX() - 1;
            int y = coo[i].getY() - 1;

            Debug.Log("$ "+x+" "+y);

            if (x >= 20 || x < 0) { }
            else if (y >= 20 || y < 0) { }
            else{
                b[x, y].setShow(true);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            determine();
        }

    }

    public static DisplayBlok findDisplayBlok(coordinate co)
    {
        return b[co.getX() - 1, co.getY() - 1];
    }

    public static DisplayWay ResetDisplayWay(string str)
    {
        return new DisplayWay(str);
    }

    public void determine()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (b[i, j].getShow() == true)
                {
                    b[i, j].setFix(true);
                }
            }
        }

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (b[i, j].getFix() == false)
                {
                    b[i, j].setColor(b[i, j].getColor()+1);
                    if(b[i, j].getColor() > 4)
                    {
                        b[i, j].setColor(1);
                    }
                }
            }
        }
    }
    
    public coordinate[] findBlok(string str, int i, int j, coordinate co)
    {
        switch (str)
        {
            case "blok1":
                return b1.requireToChange(i, j, co);
                
            case "blok2":
                return b2.requireToChange(i, j, co);
                /*
            case "blok3":
                break;
            case "blok4":
                break;
            case "blok5":
                break;
            case "blok6":
                break;
            case "blok7":
                break;
            case "blok8":
                break;
            case "blok9":
                break;
            case "blok10":
                break;
            case "blok11":
                break;
            case "blok12":
                break;
            case "blok13":
                break;
            case "blok14":
                break;
            case "blok15":
                break;
            case "blok16":
                break;
            case "blok17":
                break;
            case "blok18":
                break;
            case "blok19":
                break;
            case "blok20":
                break;
            case "blok21":
                break;
                
            default:
                return new coordinate[0];
                break;
                */
        }
        return b1.requireToChange(i, j, co);
    }

}