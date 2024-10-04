using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonReset : MonoBehaviour
{
    public Button resetButton;

    void Start()
    {
        resetButton.onClick.AddListener(ResetGame);
        resetButton.gameObject.SetActive(false);

    }

    public void ShowResetButton()
    {
        resetButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("_Scene_0");
    }
}
