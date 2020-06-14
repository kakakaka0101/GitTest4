using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClearTimeGetter : MonoBehaviour
{
    Text clearTime;


    // Start is called before the first frame update
    void Start()
    {
        clearTime = GetComponent<Text>();
        clearTime.text = ("クリアタイム"+TimeManager.clearTime.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
