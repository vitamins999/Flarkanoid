using UnityEngine;

public class BottomWall : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject ball = collision.gameObject;
        Destroy(ball);
        GameLogic.numberOfBalls--;
    }

}
