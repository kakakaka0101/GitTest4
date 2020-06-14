using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeManager : MonoBehaviour
{
    public float startTime = 300f;

    public static float clearTime;

    Text displayTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        clearTime += Time.deltaTime;

        displayTime = GetComponent<Text>();

            startTime -= Time.deltaTime;
        displayTime.text = startTime.ToString();

        if (startTime <= 0)
        {
            SceneManager.LoadScene("GameOver");

        }

    }
}
