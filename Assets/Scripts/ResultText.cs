using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("myhand" + ResultSceneManager.myhand);
        Debug.Log("enemyhand" + ResultSceneManager.enemyhand);

        if (ResultSceneManager.enemyhand == ResultSceneManager.myhand){
            GetComponent<Text>().text = "あいこ";
        }else if (ResultSceneManager.enemyhand == 1){
            if (ResultSceneManager.myhand == 3){
                GetComponent<Text>().text = "勝ち";
                GameManager.MyPoint += 1;
            }else{
                GetComponent<Text>().text = "負け";
            }
        }else if (ResultSceneManager.enemyhand == 2){
            if (ResultSceneManager.myhand == 1){        
                GetComponent<Text>().text = "勝ち";
                GameManager.MyPoint += 1;
            }
            else
            {
                GetComponent<Text>().text = "負け";
            }
        }else{
            if (ResultSceneManager.myhand == 2){        
                GetComponent<Text>().text = "勝ち";
                GameManager.MyPoint += 1;
            }
            else
            {
                GetComponent<Text>().text = "負け";
            }            
        }


    }

    
}
