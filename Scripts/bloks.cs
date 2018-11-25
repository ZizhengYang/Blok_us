using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloks : MonoBehaviour {

    // find the name of the GameObject described above
    private char[] objName = new char[12];
    private string ObjName;

    private GameObject obj;

    void Start() {
        ObjName = gameObject.name;
        objName = ObjName.ToCharArray();

        obj = GameObject.Find("" + gameObject.name);
        obj.GetComponent<Renderer>().material.color = Color.red;
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }

    void FixedUpdate()
    {
        this.updateColor(main.getABlok(methodsLib.blokCoordinate(objName)).getColor());
        this.updateDisplayStatus(main.getABlok(methodsLib.blokCoordinate(objName)).getShow());

        //b.changeColor();
    }

    public void updateColor(int color)
    {
        switch (color)
        {
            case 1:
                obj.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                obj.GetComponent<Renderer>().material.color = Color.yellow;
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

    public void updateDisplayStatus(bool show)
    {
        if (show == true)
        {
            MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr)
            {
                m.enabled = true;
            }
        }
        else if (show == false)
        {
            MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr)
            {
                m.enabled = false;
            }
        }
    }

    public void updateFix()
    {

        main.getABlok(methodsLib.blokCoordinate(objName)).changeFix();
        
    }

}
