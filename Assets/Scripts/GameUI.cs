using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    [SerializeField] Text point;
    [SerializeField] GameObject settingPanel;

    public static GameUI Instance;
    public void SetTextPoint()
    {
        point.text = GameManager.Instance.Point.ToString();
    }

    public void Awake()
    {
        if (!Instance) //if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlayGame()
    {
        AudioManager.Instance.PlaySFX("ButtonClick");
        SceneManager.LoadScene("LevelSelect");
    }

    public void BackHome()
    {
        AudioManager.Instance.PlaySFX("ButtonClick");
        SceneManager.LoadScene("Menu");
    }

    public void Setting()
    {
        AudioManager.Instance.PlaySFX("ButtonClick");
        settingPanel.SetActive(true);
    }

    public void PlayLV1()
    {
        AudioManager.Instance.PlaySFX("ButtonClick");
        AudioManager.Instance.StopMusic();
        SceneManager.LoadScene("Level1");
        AudioManager.Instance.PlayMusic("PlayGame");
    }

    public void RestartLevel()
    {
        AudioManager.Instance.PlaySFX("ButtonClick");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
