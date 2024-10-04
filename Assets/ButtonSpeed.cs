using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSpeed : MonoBehaviour
{
    public Button speedButton;

    void Start()
    {
        speedButton.onClick.AddListener(SpeedAdjust);
    }

    void SpeedAdjust()
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
