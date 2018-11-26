using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPut : MonoBehaviour {

    private const int speed = 72;
    private const int palstance = 48;

    // Update is called once per frame
    void FixedUpdate()
    {
        keyBoardInPut();
        // MouseInPut();
    }
    public void keyBoardInPut()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //main.setAngleByKey(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //main.setAngleByKey(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //main.setSideByKey(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //main.setSideByKey(false);
        }

        //========================================

        // the free moveing part
        //-X
        if (Input.GetKey(KeyCode.X))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(new Vector3(0, 0, -1 * speed * Time.deltaTime));
        }
        //-Y
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        //-Z
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1 * speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        // the rotation part
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, palstance * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, -1 * palstance * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(new Vector3(palstance * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(new Vector3(-1 * palstance * Time.deltaTime, 0, 0));
        }
    }
}
