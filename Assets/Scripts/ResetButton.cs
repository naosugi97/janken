using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
   // public void Start()
    //{
        //GameObject aaaas = GameObject.Find("MyPoint");
        //Debug.Log(aaaas);

    //}
    public void ResetButtonPushed()
    {
        GameManager.MyPoint = 0;
        MyPoint.instance.PrintSyorisu();
    }   
}
