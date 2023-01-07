using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider soundSlider, sfxSlider;
    [SerializeField] Button btnmusic, btnSFX;
    Animator animator;

    private void Update()
    {
        if(soundSlider.value > 0f)
        {
            btnmusic.animator.SetTrigger("musicON");
        }
        else
        {
            btnmusic.animator.SetTrigger("musicOFF");
            soundSlider.value = 0f;
        }

        if (sfxSlider.value > 0f)
        {
            btnSFX.animator.SetTrigger("sfxON");
        }
        else
        {
            btnSFX.animator.SetTrigger("sfxOFF");
            sfxSlider.value = 0f;
        }
    }
    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
        if(soundSlider.value > 0f) 
        { 
            soundSlider.value = 0f;
        }
        else
        {
            soundSlider.value = 100f;
        }
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
        if (sfxSlider.value > 0f)
        {
            sfxSlider.value = 0f;
        }
        else
        {
            sfxSlider.value = 100f;
        }
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(soundSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(sfxSlider.value);
    }
}
