using UnityEngine;

public class Background : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    private void Update()
    {
        StretchSpriteToScreen();
    }

    void StretchSpriteToScreen()
    {
        float screenHeight = Camera.main.orthographicSize * 2f;
        float screenWidth = screenHeight * Screen.width / Screen.height;

        transform.localScale = new Vector3(
            screenWidth / spriteRenderer.sprite.bounds.size.x,
            screenHeight / spriteRenderer.sprite.bounds.size.y,
            1f
        );
    }
}
