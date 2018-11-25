using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok {

    /*
     * Wether this blok can be changed or not
     */
    private bool fix;

    /*
     * Whether this blok is showing or not
     */
    private bool show;

    /* count which is playing
     * 
     * 1: red round
     * 2: yellow round
     * 3: green round
     * 4: blue round
     */
    private int color;

    /*
     * Find the name of the GameObject described above
     */
    //private char[] objName = new char[12];
    private string ObjName;

    //private static GameObject obj;

    public blok()
    {
        fix = false;
        show = false;
        this.color = 1;
    }

    public void setName(string str)
    {
        this.ObjName = str;
    }

    public string getName()
    {
        return this.ObjName;
    }

    public void changeFix()
    {
        this.fix = !this.fix;
    }

    public void changeShow()
    {
        if (fix == false)
        {
            this.show = !this.show;
        }
        else { }
    }

    public bool getShow()
    {
        return this.show;
    }

    public void changeColor(int color)
    {
        if (fix == false)
        {
            this.color = color;
        }
        else { }
    }

    public int getColor()
    {
        return this.color;
    }

}
