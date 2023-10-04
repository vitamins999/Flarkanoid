using UnityEngine;
using UnityEngine.InputSystem;

public class ShootBall : MonoBehaviour
{
    private PlayerInput playerInput;

    private InputAction fireAction;

    public Transform firePoint;
    public GameObject ballPrefab;

    public float ballSpeed = 3f;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        fireAction = playerInput.actions["Fire"];
    }

    void Update()
    {
        if (fireAction.triggered && GameLogic.numberOfBalls == 0)
        {
            FireBall();
        }
    }

    void FireBall()
    {   
        GameObject ball = Instantiate(ballPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 1) * ballSpeed;

        GameLogic.numberOfBalls++;
    }
}
