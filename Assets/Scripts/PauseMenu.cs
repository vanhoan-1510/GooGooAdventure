using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        AudioManager.Instance.PlaySFX("ButtonClick");
        Time.timeScale= 0f;
    }

    //private void Update()
    //{
    //    int count = 1;
    //    if (Input.GetKey("escape") && count == 1)
    //    {
    //        pauseMenu.SetActive(true);
    //        //AudioManager.Instance.PlaySFX("ButtonClick");
    //        Time.timeScale = 0f;
    //        count--;
    //    }

    //}
    public void ExitPlayGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
