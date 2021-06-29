using UnityEngine;

public class PushPlayer : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public Vector2 pushDirection = Vector2.up;

    private void FixedUpdate()
    {
        playerRigidbody.velocity += pushDirection;
    }
    private void Start()
    {
        enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out var _))
        {
            playerRigidbody = collision.GetComponent<Rigidbody2D>();
            enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (playerRigidbody &&
            collision.gameObject == playerRigidbody.gameObject)
        {
            enabled = false;
        }
    }
}
