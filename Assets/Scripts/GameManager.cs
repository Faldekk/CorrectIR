using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text scoreText;

    public float worldScrollingSpeed = 0.2f;

    private float score;

    void Awake()
    {
        if (instance == null) { instance = this; }
    }

    void FixedUpdate()
    {
        score += worldScrollingSpeed;
        UpdateOnScreenScore();
    }
    void UpdateOnScreenScore()
    {
        scoreText.text = score.ToString("0");
    }
}
