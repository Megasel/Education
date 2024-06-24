using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
public class Letters : MonoBehaviour
{
    [SerializeField] public List<Letter> letterList = new List<Letter>();
    public List<Animator> animatorList = new List<Animator>();
    public int activeIndex = 0;
    public GameObject letterObject;
    public TMP_Text descriptionText;
    public SpriteRenderer spriteObject;
    [SerializeField] private Transform point;
    public void NextLetter()
    {
        if (activeIndex == letterList.Count)
            activeIndex = 0;
        letterObject = letterList[activeIndex].letterObject;
        Instantiate(letterObject, point.position, Quaternion.identity);
        animatorList[0] = FindAnyObjectByType<Animator>();
        animatorList[0].SetBool("isLetterActive", true);
        animatorList[1].SetTrigger("end");
        animatorList[2].SetTrigger("end");

    }
    public void NextBody()
    {
        descriptionText.text = letterList[activeIndex].text;
        spriteObject.sprite = letterList[activeIndex].characterSprite;
        animatorList[1].SetTrigger("start");
        animatorList[2].SetTrigger("start");
    }
}
[Serializable]
public class Letter
{
    public GameObject letterObject;
    public Sprite characterSprite;
    [TextArea]public string text;
}