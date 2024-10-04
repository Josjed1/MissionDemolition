using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedUp : MonoBehaviour
{
    public Button speedButton;

    void Start()
    {
        speedButton.onClick.AddListener(SpeedAdjust);
    }

    public void SpeedAdjust()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 2;
        }
        else 
        {
            Time.timeScale = 1;
        }
    }
}
