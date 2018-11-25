using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPut : MonoBehaviour {

    public static void keyBoardInPut()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            display.setSideByKey(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            display.setSideByKey(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            display.setAngleByKey(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            display.setAngleByKey(false);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            main.player++;
            if (main.player > 4)
            {
                main.player = 1;
            }
        }
    }

    public static void MouseInPut()
    {
        if (Input.GetMouseButtonDown(1))
        {
            display.findBlok();
            print(display.getBlok());
        }

        if (Input.GetMouseButtonDown(0))
        {
            main.determine();
        }
    }
}
