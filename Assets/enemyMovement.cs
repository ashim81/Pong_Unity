using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    Rigidbody2D rb;
    float speed = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.y > transform.position.y){
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        else if (Ball.transform.position.y < transform.position.y){
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        else {
            rb.velocity = Vector2.zero;
        }
    }
}
