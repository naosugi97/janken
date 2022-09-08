using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class CardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{   
    
    public Transform defaulParent;
    // Transform hand = GameManager.HandTransform;

    
    public GameManager gm;
    
    // public Transform hand;
    public int ab;
    // public Transform t;
    // void Init(){
    //     hand = gameManager.HandTransform;

    // }
    public Transform hand;
    public Transform field;

    public Transform mae;

    // public void Start(){
    //     // gm = gameObject.GetComponent<GameManager>();
        
    //     // t = gm.HandTransform;
    // }
    // public GameObject child;
    
    


    public void OnBeginDrag(PointerEventData eventData){
        defaulParent = transform.parent;
        transform.SetParent(defaulParent.parent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        if (defaulParent == hand){//handのカードを操作するときいったんリストから消す
            GameManager.hlist.RemoveAt(0);
        }


        // ab = GameManager.aa;
        // t = GameManager.HandTransform;
        // t = gameManager.HandTransform;
        // ab = gameManager.aa;
        // ab = gm.GetComponent<GameManager>().aa;
        // Debug.Log(gm);
        // Debug.Log("aaaa");
        // ab = GameManager.Instance.aa;
        // Debug.Log(GameManager.instance.aa+"aa");
        // Debug.Log(GameManager.instance.HandTransform+"transform");
        hand = GameManager.instance.HandTransform;
        field = GameManager.instance.FieldTransform;
        // ab = gm.aa;

    }
    public void OnDrag(PointerEventData eventData){
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData){
        
        
        
        // GameObject child = GameManager.FieldTransform.GetChild(0).gameObject;
        // Debug.Log (child);  
        // hand = gameManager.HandTransform;
        if (defaulParent==hand){
            // Debug.Log("handddddddddddd");
            // Debug.Log(defaulParent + "defaultParent.parent");
            // transform.SetParent(field, false);
            GameManager.hlist.Add(this);

            // Debug.Log(GameManager.hlist.Count + "hlist.Count");
            if (GameManager.hlist.Count == 2){
                // Debug.Log(GameManager.hlist[0]);
                GameManager.hlist[0].transform.SetParent(field, false);
                GameManager.hlist.RemoveAt(0);

            }
        }else{
            // Debug.Log("elseeeee");

        }
        transform.SetParent(defaulParent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true;


        // child = transform.Find("name").gameObject;
        // var na = child.GetComponent<Text>();
        // Debug.Log(na.text);
        // var hensu = GameManager.GetComponent<>().
        // Debug.Log(ab);
        // Debug.Log(hand);
        // Debug.Log(ab);
        // Debug.Log(defaulParent);
    }
    
    
}
