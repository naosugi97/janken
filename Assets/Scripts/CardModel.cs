using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カードデータそのものとその処理
public class CardModel 

{
    public string name;
    public Sprite icon;

    public CardModel(int cardID){
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntities/Card"+cardID);
        name = cardEntity.name;
        icon = cardEntity.icon;
    }
}
