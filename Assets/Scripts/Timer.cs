using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using TMPro;

public class Timer : MonoBehaviour
{
    float countTime;
    // public TextMeshProUGUI timetext;
    // Start is called before the first frame update
    // public GotoResult gr;
    void Start()
    {
        countTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // countTimeに、ゲームが開始してからの秒数を格納
        countTime -= Time.deltaTime;

        // 小数2桁にして表示
        GetComponent<Text>().text = countTime.ToString("F2");
        // timetext.text = "aaa";
        if (countTime < 0.0){
            Debug.Log("00000");
            GotoResult.instance.SceneChange();
        }

    }
}
