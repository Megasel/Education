using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskEnable : MonoBehaviour
{
    private SpriteMask spriteMask;
    CircleCount circleCount;
    Letters letters;
    
    private void Awake()
    {
        letters = FindAnyObjectByType<Letters>();
        spriteMask = GetComponent<SpriteMask>();
        circleCount = transform.parent.GetComponent<CircleCount>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (GetComponent<CircleCollider2D>().OverlapPoint(mousePosition))
            {
                
                circleCount.masks.Remove(spriteMask);
                if(circleCount.masks.Count == 0 && circleCount.isAnimStarted == false)
                {
                    circleCount.Next();
                    Debug.Log("!");
                    
                    transform.parent.GetComponent<Animator>().SetBool("isLetterActive", false);
                }
                spriteMask.enabled = true;
            }
        }
    }
} 
