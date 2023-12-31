using UnityEngine;

public class Block : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer;

    public AudioClip blockHitSFX;

    public Rigidbody2D rb;

    public int difficultyLevel;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    public void ChangeSprite()
    {
        if (difficultyLevel > 0)
        {
            spriteRenderer.sprite = sprites[difficultyLevel - 1];
            difficultyLevel--;
        } else
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.BlockDestroyed();
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(blockHitSFX, transform.position);

        ChangeSprite();

        GameManager gameManager = FindObjectOfType<GameManager>();
        
        gameManager.Hit();
    }
}
