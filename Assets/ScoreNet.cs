using UnityEngine;

public class ScoreNet : MonoBehaviour
{
    [SerializeField] ScoreCounter scoreCounter;
    [SerializeField] BallMovement ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        scoreCounter.score++;
        ball.transform.position = ball.startPos;
        ball.launch();
    }
}
