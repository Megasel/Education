using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    private Toggle toggle;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private string soundType;
    private void Start()
    {
        toggle = GetComponent<Toggle>();
        if (PlayerPrefs.HasKey(soundType))
        {
            
            if(PlayerPrefs.GetInt(soundType) == 1)
            {
                audioSource.enabled = true;
                toggle.isOn = true;
            }
            else
            {
                audioSource.enabled = false;
                toggle.isOn = false;
            }
        }
        else
        {
            PlayerPrefs.SetInt(soundType, 1);
            toggle.isOn = true;
            audioSource.enabled = true;
        }
    }
    public void Toogle()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt(soundType, 1);
            audioSource.enabled= true;
        }
        else
        {
            PlayerPrefs.SetInt(soundType, 0);
            audioSource.enabled = false;
        }
        
    }


}
