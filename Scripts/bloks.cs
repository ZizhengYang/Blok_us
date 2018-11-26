using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloks : MonoBehaviour {

    private string objName;
    private GameObject obj;
    private coordinate co;

    void Start()
    {
        objName = gameObject.name;
        obj = GameObject.Find(objName);
        co = StaticMethodLib.stringTOcoordinate(objName);
    }
    void FixedUpdate()
    {
        DisplayBlok dis = Main.findDisplayBlok(co);

        this.updateColor(dis.getColor());
        this.updateDisplayStatus(dis.getShow());
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
    
}
