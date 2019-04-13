using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject gameover;
    public void restartbutton()
    {
        gameover.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
