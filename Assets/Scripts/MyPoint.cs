using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPoint : MonoBehaviour
{
    public static MyPoint instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        PrintSyorisu();
    }

    public void PrintSyorisu()
    {
        GetComponent<Text>().text = GameManager.MyPoint.ToString();
    }
}
