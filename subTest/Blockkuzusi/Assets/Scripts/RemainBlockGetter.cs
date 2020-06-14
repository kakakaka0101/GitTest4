using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainBlockGetter : MonoBehaviour
{
    Text RemainBlock;

    void GetBlockNum()
    {
        RemainBlock = GetComponent<Text>();
        RemainBlock.text = ("残りブロック数"+BlockController.boxNum.ToString());


    }


    // Start is called before the first frame update
    void Start()
    {
        GetBlockNum();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
