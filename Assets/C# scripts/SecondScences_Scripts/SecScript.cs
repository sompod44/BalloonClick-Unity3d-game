using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecScript : MonoBehaviour
{
    public GameObject gameover;
    public Text sec;
    public Text scoure;
    private int value = 0;
    public int x = 1;
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if(x == 0)
        {
            if (value < 30)
            {
                value += 1;
                sec.text = value.ToString("0");
            }
            if(value == 30)
            {
                Time.timeScale = 0;
                gameover.SetActive(true);
            }
        }

    }
}
