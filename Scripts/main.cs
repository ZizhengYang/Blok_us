using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    //=========================================================================
    bool[] visableY = new bool[22];
    bool[] visableR = new bool[22];
    bool[] visableG = new bool[22];
    bool[] visableB = new bool[22];
    char[] blokname = new char[20];

    public bool PoE = false;
    // default values
    /* count which is playing
     * 
     * 1: yellow round
     * 2: red round
     * 3: green round
     * 4: blue round
     */
    static public int player = 0;
    /* count which kind of blok is choosen
     * 
     * too many of them (20 types)
     * I woun't write all of them here
     * LOL
     */
    static public int blok = 0;
    /* which side is choosen
     * 
     * 1 the front side (the side players can see)
     * 2 the back side
     * 
     * # some bloks may not have all sides
     */
    static public int side = 1;
    /* which angle is choosen
     * 
     * 1 no change
     * 2 turn right for 90'
     * 3 upside down
     * 4 turn left for 90'
     * 
     * # some bloks may not have all angles
     */
    static public int angle = 1;
    //=========================================================================

    //=========================================================================
    void Awake()
    {
        for(int i = 0; i < 22; i++)
        {
            visableY[i] = true;
            visableR[i] = true;
            visableG[i] = true;
            visableB[i] = true;
        }
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            findBlok();

            print(blok);
        }

        keyboard();
    }
    //=========================================================================

    //=========================================================================
    public void findBlok()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "blok1")
            {
                blok = 1;
            }
            else if (hit.collider.gameObject.name == "blok2")
            {
                blok = 2;
            }
            else if (hit.collider.gameObject.name == "blok3")
            {
                blok = 3;
            }
            else if (hit.collider.gameObject.name == "blok4")
            {
                blok = 4;
            }
            else if (hit.collider.gameObject.name == "blok5")
            {
                blok = 5;
            }
            else if (hit.collider.gameObject.name == "blok6")
            {
                blok = 6;
            }
            else if (hit.collider.gameObject.name == "blok7")
            {
                blok = 7;
            }
            else if (hit.collider.gameObject.name == "blok8")
            {
                blok = 8;
            }
            else if (hit.collider.gameObject.name == "blok9")
            {
                blok = 9;
            }
            else if (hit.collider.gameObject.name == "blok10")
            {
                blok = 10;
            }
            else if (hit.collider.gameObject.name == "blok11")
            {
                blok = 11;
            }
            else if (hit.collider.gameObject.name == "blok12")
            {
                blok = 12;
            }
            else if (hit.collider.gameObject.name == "blok13")
            {
                blok = 13;
            }
            else if (hit.collider.gameObject.name == "blok14")
            {
                blok = 14;
            }
            else if (hit.collider.gameObject.name == "blok15")
            {
                blok = 15;
            }
            else if (hit.collider.gameObject.name == "blok16")
            {
                blok = 16;
            }
            else if (hit.collider.gameObject.name == "blok17")
            {
                blok = 17;
            }
            else if (hit.collider.gameObject.name == "blok18")
            {
                blok = 18;
            }
            else if (hit.collider.gameObject.name == "blok19")
            {
                blok = 19;
            }
            else if (hit.collider.gameObject.name == "blok20")
            {
                blok = 20;
            }
            else if (hit.collider.gameObject.name == "blok21")
            {
                blok = 21;
            }
        }
    }
    //=========================================================================

    //=========================================================================
    private void keyboard()
    {
        //--------------------------------starting the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(PoE == false)
            {
                player = 1;
            }
            else
            {
                player = 0;
            }
            PoE = !PoE;
        }
        //--------------------------------
        if (Input.GetKeyDown(KeyCode.W))
        {
            side += 1;
            if(side > 2)
            {
                side = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            side -= 1;
            if(side < 1)
            {
                side = 2;
            }
        }
        //--------------------------------
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
        //--------------------------------
    }
    //=========================================================================
}