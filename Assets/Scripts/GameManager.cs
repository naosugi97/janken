using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public static GameManager Instance{get; private set;}
    public static GameManager instance;
    //手札にカードを生成
    [SerializeField] public Transform FieldTransform;//位置に関するものはTransform
    [SerializeField] public Transform HandTransform;
    [SerializeField] CardController cardPrefab;
    public int aa;


    // [SerializeField] Transform HandTransform;

    public static List<CardMovement> hlist = new List<CardMovement>();
    public void Awake(){
        if(instance == null){
            instance = this;
            // DontDestroyOnLoad(this.gameObject);//破壊されないオブジェクト（次の
        }
        
        hlist.Clear();//いったん手札のリストを空にする


    }
    void Start(){

        aa = 5;
    
        CreateCard(FieldTransform, 1);//guu
        CreateCard(FieldTransform, 2);//tyoki
        CreateCard(FieldTransform, 3);//paa
    }
    void CreateCard(Transform hand, int cardID){
        CardController card = Instantiate(cardPrefab, hand, false);//cardPrefabをhandの下にインスタンス化する
        card.Init(cardID);
        // GameObject child = FieldTransform.GetChild(0).gameObject;
        // Debug.Log (child);


        
    }
}
