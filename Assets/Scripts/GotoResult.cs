using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GotoResult : MonoBehaviour
{
    public GameObject handcard;
    public GameObject hchild;
    public static string hnum;

    public static GotoResult instance;
    // public var handname;
    void Awake()
    {
        if(instance == null){
            instance = this;
        }
    }


    public void GotoResultButton(){


        if (GameManager.hlist.Count==1){

            SceneChange();

        }

    }

    public void SceneChange(){
        if (GameManager.hlist.Count == 0){//時間切れで手札にカードが置かれていなかった時の処理
            hnum = "rand";
        }else{
            handcard = GameManager.hlist[0].gameObject;
            hchild = handcard.transform.Find("name").gameObject;
            // Debug.Log(hchild.name);
            hnum = hchild.GetComponent<Text>().text;
        }
        Debug.Log(hnum);
        
        // var handname = transform.Find("name").gameObject.GetComponent<Text>();
        // Debug.Log(handname);
        SceneManager.LoadScene("ResultSene");
    }

}
