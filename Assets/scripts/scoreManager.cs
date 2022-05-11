using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public Text scoreText;
    public Text moneyText;
    public Text HSText;

    public static int score = 0;
    public static int money = 10000;
    public static int highScore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        moneyText.text = "Money: " + money.ToString();
        HSText.text = "HS: " + highScore.ToString();
    }

    void Update()
    {
        if (score > highScore)
        {
            highScore = score;
        }
        HSText.text = "HS: " + highScore.ToString();
        scoreText.text = "Score: " + score.ToString();
        moneyText.text = "Money: " + money.ToString();
    }

    public void AddPoints()
    {
        score += 50;
        money += 25;
        scoreText.text = "Score: " + score.ToString();
        moneyText.text = "Money: " + money.ToString();
    }
}
