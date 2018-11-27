using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayBlok
{
    private int color;
    private bool show;
    private bool fix;

    public DisplayBlok()
    {
        this.color = 1;
        this.show = false;
        this.fix = false;
    }

    public int getColor()
    {
        return this.color;
    }

    public bool getShow()
    {
        return this.show;
    }

    public bool getFix()
    {
        return this.fix;
    }
    public void setColor(int givenColor)
    {
        this.color = givenColor;
    }

    public void setShow(bool givenShow)
    {
        this.show = givenShow;
    }

    public void setFix(bool givenFix)
    {
        this.fix = givenFix;
    }

}