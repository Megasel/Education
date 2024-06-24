using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    [SerializeField] Letters letters;
    [SerializeField] AudioSource aud;
    public void Next()
    {
        aud.Play();
        letters.activeIndex++;
        letters.NextLetter();
        gameObject.SetActive(false);
    }

}
