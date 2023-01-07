using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public PlayerMovement player;
    public CameraController cameraControl;

    public int Point { get; set; }

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (!Instance) //if (Instance == null)
        {
            Instance = this;
        }
    }
}