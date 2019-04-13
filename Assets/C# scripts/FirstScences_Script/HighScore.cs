using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public GameObject hs;
    public Text score;
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = PlayerPrefs.GetInt("HighScoure", 0);
    }

    public void click()
    {
        hs.SetActive(true);
        score.text = x.ToString();
    }
}
