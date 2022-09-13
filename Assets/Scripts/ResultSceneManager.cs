using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;//rand使うため

public class ResultSceneManager : MonoBehaviour
{
    // public static GameManager Instance{get; private set;}
    public static ResultSceneManager instance;
    //手札にカードを生成
    [SerializeField] public Transform EnemyHandTransform;//位置に関するものはTransform
    [SerializeField] public Transform HandTransform;
    [SerializeField] CardController cardPrefab;

    public static int enemyhand;
    public static int myhand;


    public void Awake(){
        if(instance == null){
            instance = this;
            // DontDestroyOnLoad(this.gameObject);//破壊されないオブジェクト（次の
        }
        enemyhand = Random.Range(1, 4);
        // Debug.Log("enemyhand" + enemyhand);
        // Debug.Log("自分の手札" + GotoResult.hnum);
        if (GotoResult.hnum == "guu"){
            myhand = 1;

        }else if (GotoResult.hnum == "tyoki"){
            myhand = 2;
        }else if (GotoResult.hnum == "paa"){
            myhand = 3;
        }else{
            myhand = Random.Range(1, 4);
        }   

    }
    void Start(){

    
        CreateCard(EnemyHandTransform, enemyhand);//自分の手札のカードを再生成
        CreateCard(HandTransform, myhand);
        
        // if (GotoResult.hnum == "guu"){
        //     myhand = 1;
        //     CreateCard(HandTransform, 1);

        // }else if (GotoResult.hnum == "tyoki"){
        //     myhand = 2;
        //     CreateCard(HandTransform, 2);
        // }else if (GotoResult.hnum == "paa"){
        //     myhand = 3;
        //     CreateCard(HandTransform, 3);
        // }else{
        //     myhand = Random.Range(1, 4);
        //     CreateCard(HandTransform, myhand);
        // }
        
        
    }


    
    void CreateCard(Transform hand, int cardID){
        CardController card = Instantiate(cardPrefab, hand, false);//cardPrefabをhandの下にインスタンス化する
        card.Init(cardID);
        // GameObject child = FieldTransform.GetChild(0).gameObject;
        // Debug.Log (child);


        
    }
}
