using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleButton : MonoBehaviour
{
    [SerializeField] private GameObject button;
    public void OffButton()
    {
        button.SetActive(false);
    }
    public void OnButton()
    {
        button.SetActive(true);
    }
}
