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

        howToDisplay(main.blok, main.side, main.angle);
    }

    public void OnMouseExit()
    {
        howToHide(main.blok, main.side, main.angle);
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

    private void howToDisplay(int index, int side, int angle)
    {
        if (index == 0)
        {
            S_special_condition();
        }
        else if (index == 9)
        {
            if (side == 1 && angle == 1)
            {
                S_Blok9_side1_angle1();
            }
            else if (side == 1 && angle == 2)
            {
                S_Blok9_side1_angle2();
            }
            else if (side == 1 && angle == 3)
            {
                S_Blok9_side1_angle3();
            }
            else if (side == 1 && angle == 4)
            {
                S_Blok9_side1_angle4();
            }
            else if (side == 2 && angle == 1)
            {
                S_Blok9_side2_angle1();
            }
            else if (side == 2 && angle == 2)
            {
                S_Blok9_side2_angle2();
            }
            else if (side == 2 && angle == 3)
            {
                S_Blok9_side2_angle3();
            }
            else if (side == 2 && angle == 4)
            {
                S_Blok9_side2_angle4();
            }
        }
    }

    private void howToHide(int index, int side, int angle)
    {
        if (index == 0)
        {
            H_special_condition();
        }
        else if (index == 9)
        {
            if (side == 1 && angle == 1)
            {
                H_Blok9_side1_angle1();
            }
            else if (side == 1 && angle == 2)
            {
                H_Blok9_side1_angle2();
            }
            else if (side == 1 && angle == 3)
            {
                H_Blok9_side1_angle3();
            }
            else if (side == 1 && angle == 4)
            {
                H_Blok9_side1_angle4();
            }
            else if (side == 2 && angle == 1)
            {
                H_Blok9_side2_angle1();
            }
            else if (side == 2 && angle == 2)
            {
                H_Blok9_side2_angle2();
            }
            else if (side == 2 && angle == 3)
            {
                H_Blok9_side2_angle3();
            }
            else if (side == 2 && angle == 4)
            {
                H_Blok9_side2_angle4();
            }
        }
    }
    //=========================================================================

    //=========================================================================
    static private char IntToChar(int i)
    {
        char c = ' ';

        if (i == 0)
        {
            c = '0';
        }
        else
        {
            c = (char)(i + 48);
        }

        return c;
    }
    private void gameobjectToZero()
    {
        obj1 = null;
        obj2 = null;
        obj3 = null;
        obj4 = null;
    }

    private string blokCoordinate(char[] temp, int Xoffset, int Yoffset)
    {
        string newstring = "";

        int tempX = 0;
        int tempY = 0;

        tempX = (temp[5] - '0') * 10 + (temp[6] - '0');
        tempY = (temp[9] - '0') * 10 + (temp[10] - '0');

        tempX = tempX + Xoffset;
        tempY = tempY + Yoffset;

        newstring += "blok(";
        newstring += IntToChar(tempX / 10);
        newstring += IntToChar(tempX % 10);
        newstring += ")(";
        newstring += IntToChar(tempY / 10);
        newstring += IntToChar(tempY % 10);
        newstring += ")";

        return newstring;
    }
    //=========================================================================

    //=========================================================================
    //-------------------------------------------------------------------------
    private void S_special_condition()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
    }
    private void H_special_condition()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }
    //-------------------------------------------------------------------------
    private void S_Blok9_side1_angle1()
    {
        // initializing
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(blokCoordinate(temp, -1, 0));
        obj3 = GameObject.Find(blokCoordinate(temp, -2, 0));
        
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
        MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr1)
        {
            m.enabled = true;
        }
        MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr2)
        {
            m.enabled = true;
        }
        MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr3)
        {
            m.enabled = true;
        }
        
        gameobjectToZero();
    }
    private void S_Blok9_side1_angle2()
    {

    }
    private void S_Blok9_side1_angle3()
    {

    }
    private void S_Blok9_side1_angle4()
    {

    }
    private void S_Blok9_side2_angle1()
    {

    }
    private void S_Blok9_side2_angle2()
    {

    }
    private void S_Blok9_side2_angle3()
    {

    }
    private void S_Blok9_side2_angle4()
    {

    }
    
    private void H_Blok9_side1_angle1()
    {
        // initializing
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(blokCoordinate(temp, -1, 0));
        obj3 = GameObject.Find(blokCoordinate(temp, -2, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
        MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr1)
        {
            m.enabled = false;
        }
        MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr2)
        {
            m.enabled = false;
        }
        MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr3)
        {
            m.enabled = false;
        }

        gameobjectToZero();
    }
    private void H_Blok9_side1_angle2()
    {

    }
    private void H_Blok9_side1_angle3()
    {

    }
    private void H_Blok9_side1_angle4()
    {

    }
    private void H_Blok9_side2_angle1()
    {

    }
    private void H_Blok9_side2_angle2()
    {

    }
    private void H_Blok9_side2_angle3()
    {

    }
    private void H_Blok9_side2_angle4()
    {

    }
    //-------------------------------------------------------------------------
    //=========================================================================

    //=========================================================================

    //=========================================================================
}
