using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloks : MonoBehaviour {

    /*
     * 
     */
    private static bool fix = false;

    /*
     * 
     */
    private static bool show = false;

    /* count which is playing
     * 
     * 1: yellow round
     * 2: red round
     * 3: green round
     * 4: blue round
     */
    // Ok, I admit, this is useless
    private int color = 0;

    // find the name of the GameObject described above
    private static char[] objName = new char[12];
    private static string ObjName;

    private static GameObject obj;

    void Start()
    {
        ObjName = gameObject.name;
        objName = ObjName.ToCharArray();

        obj = GameObject.Find("" + gameObject.name);
        obj.GetComponent<Renderer>().material.color = Color.black;
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }

    public static void changeColor(int color)
    {
        switch (color)
        {
            case 1:
                obj.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 2:
                obj.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                obj.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                obj.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                break;
        }
    }

    public static void changeDisplayStatus()
    {
        if(show == true)
        {
            MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr)
            {
                m.enabled = false;
            }
        }
        else if(show == false)
        {
            MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr)
            {
                m.enabled = true;
            }
        }
    }

}
