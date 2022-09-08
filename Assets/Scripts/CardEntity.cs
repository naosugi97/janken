using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardEntity", menuName = "Create CardEntity")]
//カードデータそのもの
public class CardEntity : ScriptableObject
{
    public new string name;
    public Sprite icon;
}
