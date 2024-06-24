using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject bg;
    public void Toogle()
    {
        if(panel.activeSelf)
        {
            panel.SetActive(false);
            bg.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
            bg.SetActive(true);
        }
    }

}
