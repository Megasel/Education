using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CircleCount : MonoBehaviour
{
    [SerializeField] public List<SpriteMask> masks = new List<SpriteMask>();
    [SerializeField] Letters letters;
    public bool isAnimStarted = false;
    AudioSource aud;
    private void Start()
    {
        masks = FindObjectsByType<SpriteMask>(FindObjectsSortMode.None).ToList() ;
        letters = FindAnyObjectByType<Letters>();
        aud = GetComponent<AudioSource>();
    }
    public void Next()
    {
        aud.volume = PlayerPrefs.GetInt("soundvolume");
        aud.Play();
        letters.NextBody();
        isAnimStarted = true;
    }
}
