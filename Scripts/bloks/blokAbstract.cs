using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class blokAbstract : MonoBehaviour {

    protected GameObject obj0 = null;
    protected GameObject obj1 = null;
    protected GameObject obj2 = null;
    protected GameObject obj3 = null;
    protected GameObject obj4 = null;

    protected GameObject[] objArray = new GameObject[5];

    void Start()
    {
        objArray[0] = obj0;
        objArray[1] = obj1;
        objArray[2] = obj2;
        objArray[3] = obj3;
        objArray[4] = obj4;
    }

}
