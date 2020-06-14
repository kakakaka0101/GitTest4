using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallController : MonoBehaviour
{

    AudioSource SoundEffect;



    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0,45);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 500);

        SoundEffect = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Block"))
        {
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);

            SoundEffect.Play();


            BlockController.boxNum --;
            if(BlockController.boxNum <= 0)
            {
                SceneManager.LoadScene("GameClear");

            }


        }
        if (other.gameObject.CompareTag("Bottom"))
        {
            SceneManager.LoadScene("GameOver");
        }


    }
}
