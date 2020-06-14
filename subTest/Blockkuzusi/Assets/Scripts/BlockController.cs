using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public GameObject blockResources;
    public Transform blockParent;
    // Start is called before the first frame update

        //ブロックの軸の 数
    public static int blockX = 1;
    public static int blockY = 1;

    public static int boxNum = blockX * blockY;



    void Awake()
    {
        for(int x = 0; x<blockX; x++)
        {
            for(int y = 0; y<blockY; y++)
            {
                GameObject blocks = Instantiate(blockResources,blockParent);
                blocks.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);


            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
