using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAmbient : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("ambientVolume"))
        {
            if (PlayerPrefs.GetInt("ambientVolume") == 1)
            {
                audioSource.enabled = true;
            }
            else
            {
                audioSource.enabled = false;
            }
        }
        else
        {
            PlayerPrefs.SetInt("ambientVolume", 1 );
            audioSource.enabled = true;
        }
    }

}
