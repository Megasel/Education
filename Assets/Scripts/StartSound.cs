using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSound : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("soundvolume"))
        {
            if (PlayerPrefs.GetInt("soundvolume") == 1)
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
            PlayerPrefs.SetInt("soundvolume", 1);
            audioSource.enabled = true;
        }
    }

}
