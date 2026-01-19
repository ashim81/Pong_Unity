using UnityEngine;
using TMPro;
public class ScoreCounter : MonoBehaviour
{
    TextMeshProUGUI textesh;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textesh.text = score.ToString();
    }
}
