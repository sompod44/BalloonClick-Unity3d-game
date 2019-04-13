using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class TapButton : MonoBehaviour
{
    public AudioSource tap;
    public GameObject SadBalloon;
    public GameObject SmileBalloon;
    public Text point;
    private int click = 0;
    private int p = 0;
    int x;
    private void Start()
    {
        x = PlayerPrefs.GetInt("HighScoure", 0);
    }
    public void TapClick()
    {
        if (click == 0)
        {
            SmileBalloon.SetActive(false);
            SadBalloon.SetActive(true);
            ++p;
            point.text = p.ToString("0");
            tap.Play();
            int scoure = Convert.ToInt32(point.text.ToString());
            if (x >= 0)
            {
                if(scoure > x)
                {
                    PlayerPrefs.SetInt("HighScoure", scoure); // this  method can store the game high scoure
                }
            }
            
            click = 1;
        }
        else
        {
            SmileBalloon.SetActive(true);
            SadBalloon.SetActive(false);
            click = 0;
        }
    }
}
