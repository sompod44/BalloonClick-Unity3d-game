using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKButton : MonoBehaviour
{
    public GameObject panel;
    public void OK()
    {
        GameObject SecCount = GameObject.Find("SecCount");
        SecScript SS = SecCount.GetComponent<SecScript>();

        panel.SetActive(false);
        SS.x = 0;

    }
}
