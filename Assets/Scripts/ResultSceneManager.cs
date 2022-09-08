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

    public int enemyhand;


    public void Awake(){
        if(instance == null){
            instance = this;
            // DontDestroyOnLoad(this.gameObject);//破壊されないオブジェクト（次の
        }
        enemyhand = Random.Range(1, 4);
        // Debug.Log("enemyhand" + enemyhand);
        Debug.Log("自分の手札" + GotoResult.hnum);


    }
    void Start(){

    
        CreateCard(EnemyHandTransform, enemyhand);//自分の手札のカードを再生成
        if (GotoResult.hnum == "guu"){
            CreateCard(HandTransform, 1);
        }else if (GotoResult.hnum == "tyoki"){
            CreateCard(HandTransform, 2);
        }else{
            CreateCard(HandTransform, 3);
        }
        
    }


    
    void CreateCard(Transform hand, int cardID){
        CardController card = Instantiate(cardPrefab, hand, false);//cardPrefabをhandの下にインスタンス化する
        card.Init(cardID);
        // GameObject child = FieldTransform.GetChild(0).gameObject;
        // Debug.Log (child);


        
    }
}
