using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloks : MonoBehaviour {

    //=========================================================================
    // find the GameObject that need to change clolor
    private GameObject obj;
    // surronding game objects
    private GameObject obj1 = null;
    private GameObject obj2 = null;
    private GameObject obj3 = null;
    private GameObject obj4 = null;
    // find the name of the GameObject described above
    private char[] objName = new char[12];
    private string ObjName;
    //=========================================================================

    //=========================================================================
    // Use this for initialization
    void Start() {

        // change the current game object name to char array
        // format:
        // blok(  )(  )
        // 012345678901
        ObjName = gameObject.name;
        objName = ObjName.ToCharArray();

        // settle color as black
        // settle visable as false
        obj = GameObject.Find("" + gameObject.name);
        obj.GetComponent<Renderer>().material.color = Color.black;
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

    }

    // Update is called once per frame
    void Update() {

    }
    //=========================================================================

    //=========================================================================
    public void OnMouseEnter()
    {
        whatIsCurrentColor(main.player);

        howToDisplay(main.blok, main.condition);
    }

    public void OnMouseExit()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }
    //=========================================================================

    //=========================================================================
    public void whatIsCurrentColor(int index)
    {
        if (index == 1)
        {
            obj.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (index == 2)
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (index == 3)
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (index == 4)
        {
            obj.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    private void howToDisplay(int index, int condition)
    {
        if (index == 0)
        {
            special_condition();
        }
        else if (index == 9)
        {
            if (condition == 1)
            {
                Blok9_side1_angle1();
            }
            else if (condition == 2)
            {
                Blok9_side1_angle2();
            }
            else if (condition == 3)
            {
                Blok9_side1_angle3();
            }
            else if (condition == 4)
            {
                Blok9_side1_angle4();
            }
            else if (condition == 5)
            {
                Blok9_side2_angle1();
            }
            else if (condition == 6)
            {
                Blok9_side2_angle2();
            }
            else if (condition == 7)
            {
                Blok9_side2_angle3();
            }
            else if (condition == 8)
            {
                Blok9_side2_angle4();
            }
        }
    }

    private void howToHide(int index)
    {

    }
    //=========================================================================

    //=========================================================================
    private void gameobjectToZero()
    {
        obj1 = null;
        obj2 = null;
        obj3 = null;
        obj4 = null;
    }

    private char[] blokCoordinate(char[] temp, int Xoffset, int Yoffset)
    {
        char[] newarray = new char[temp.Length];
        newarray = temp;

        int tempX = 0;
        int tempY = 0;

        tempX = (int)(temp[5] * 10) + (int)(temp[6]);
        tempY = (int)(temp[9] * 10) + (int)(temp[10]);

        tempX = tempX + Xoffset;
        tempY = tempY + Yoffset;

        newarray[5] = (char)(tempX / 10);
        newarray[6] = (char)(tempX % 10);
        newarray[9] = (char)(tempY / 10);
        newarray[10] = (char)(tempY % 10);

        return newarray;
    }
    //=========================================================================

    //=========================================================================
    //-------------------------------------------------------------------------
    private void special_condition()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
    }
    //-------------------------------------------------------------------------
    private void Blok9_side1_angle1()
    {
        // initializing
        char[] temp = new char[objName.Length];

        obj1 = GameObject.Find("" + blokCoordinate(temp, -1, 0));
        obj2 = GameObject.Find("" + blokCoordinate(temp, 0, -1));
        obj3 = GameObject.Find("" + blokCoordinate(temp, 0, -2));
        /*
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
        MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
        MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
        MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
        */
        gameobjectToZero();
    }
    private void Blok9_side1_angle2()
    {

    }
    private void Blok9_side1_angle3()
    {

    }
    private void Blok9_side1_angle4()
    {

    }
    private void Blok9_side2_angle1()
    {

    }
    private void Blok9_side2_angle2()
    {

    }
    private void Blok9_side2_angle3()
    {

    }
    private void Blok9_side2_angle4()
    {

    }
    //-------------------------------------------------------------------------
    //=========================================================================
}
