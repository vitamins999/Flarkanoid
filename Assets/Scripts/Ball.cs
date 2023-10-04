using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject paddle;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = 1;

        rb.velocity = new Vector2(x, y) * speed;
    }
}
