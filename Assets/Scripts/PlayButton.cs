using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] Letters letters;
    [SerializeField] private GameObject title;
    public void Play()
    {
        Instantiate(letters.letterList[letters.activeIndex].letterObject);
        
        gameObject.SetActive(false);
        title.SetActive(false);
    }
}
