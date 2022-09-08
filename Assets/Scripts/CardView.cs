using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel){
        nameText.text = cardModel.name;
        iconImage.sprite = cardModel.icon;
    }

}
