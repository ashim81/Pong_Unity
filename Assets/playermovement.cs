using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float playerSpeed = 5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("Vertical") * playerSpeed);
    }
}
