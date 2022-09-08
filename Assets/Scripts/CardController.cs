using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    //みかけに関する捜査(view)
    CardView view;
    //データに関することを捜査(model)
    CardModel model;
    
    public void Awake(){
      view = GetComponent<CardView>();
    }
    //Iint
    public void Init(int cardID){
        model=new CardModel(cardID);
        view.Show(model);
    }

}
