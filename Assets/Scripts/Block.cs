using UnityEngine;

public class Block : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer;

    public AudioSource blockHitSFX;

    public Rigidbody2D rb;

    public int difficultyLevel;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        blockHitSFX = GetComponent<AudioSource>();
    }

    
    public void ChangeSprite()
    {
        if (difficultyLevel > 0)
        {
            spriteRenderer.sprite = sprites[difficultyLevel - 1];
            difficultyLevel--;
        } else
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        blockHitSFX.Play();

        ChangeSprite();
        GameManager.playerScore += 10;
    }
}
