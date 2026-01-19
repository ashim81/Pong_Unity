using UnityEngine;

public class BallMovement : MonoBehaviour
{
    float speed = 5;
    Rigidbody2D rb;
    public Vector2 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        launch();

    }

    public void launch(){
        int x = Random.Range(0, 2);
        int y = Random.Range(0, 2);

        if (x == 0){
            x = -1;
        }
        if (y == 0){
            y = -1;
        }

        rb.velocity = new Vector2(x* speed, y* speed);
    }
}
