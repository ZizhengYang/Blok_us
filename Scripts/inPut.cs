using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPut : MonoBehaviour {

    // Update is called once per frame
    void FixedUpdate()
    {
        keyBoardInPut();
        MouseInPut();
    }
    public static void keyBoardInPut()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            main.setAngleByKey(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            main.setAngleByKey(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            main.setSideByKey(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            main.setSideByKey(false);
        }

        //========================================



        //========================================

        if (Input.GetKeyDown(KeyCode.P))
        {
            main.setPlayerByKey();
        }
    }

    public static void MouseInPut()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            main.determine();
        }
    }
}
