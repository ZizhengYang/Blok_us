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
    public int player = 0;

    /*
     * A Display type object
     */
    public display d;

    void Awake()
    {

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
            display.findBlok();

            print(display.getBlok());
        }

        //keyboard();
    }

    public void whatIsCurrentColor(int index, GameObject obj)
    {

    }

    private void howToDisplay(int index, int side, int angle)
    {

    }

    private void howToHide(int index, int side, int angle)
    {

    }

    private void keyboard()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            player++;
            if (player > 4)
            {
                player = 1;
            }
        }
    }
}
