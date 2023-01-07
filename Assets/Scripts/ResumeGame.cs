using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{

    public void ResuneGame()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
