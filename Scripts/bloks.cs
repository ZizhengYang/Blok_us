using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloks : MonoBehaviour {


    // find the GameObject that need to change clolor
    private GameObject obj;
    // find the name of the GameObject described above
    private char[] objName = new char[12];
    private string ObjName;

	// Use this for initialization
	void Start () {

        // change the current game object name to char array
        // format:
        // blok(  )(  )
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
	void Update () {
        for(int i = 0; i < 12; i++)
        {
            print(objName[i]);
        }
    }

    public void OnMouseEnter()
    {
        whatIsCurrentColor(main.player);
        
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
    }

    public void OnMouseExit()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }

    public void whatIsCurrentColor(int index)
    {
        if(index == 1)
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
        if(index == 0)
        {
            Blok9_special_condition();
        }
        else if(index == 9)
        {
            if(condition == 1)
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

    private void Blok9_special_condition()
    {

    }

    private void Blok9_side1_angle1()
    {

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
}
