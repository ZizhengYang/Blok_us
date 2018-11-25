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
    public static int player = 0;

    /*
     * A Display type object
     */
    //public display d;

    private GameObject[] objects = new GameObject[5];

    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        inPut.keyBoardInPut();
        inPut.MouseInPut();

    }

    public void OnMouseEnter()
    {
        howToDisplay(display.getBlok(), display.getSide(), display.getAngle());
    }

    public void OnMouseExit()
    {
        howToHide(display.getBlok(), display.getSide(), display.getAngle());
    }

    private static void howToDisplay(int index, int side, int angle)
    {

    }

    private static void howToHide(int index, int side, int angle)
    {

    }

    public static void determine()
    {
        
    }
}
