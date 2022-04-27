using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public Text scoreText;
    public Text moneyText;

    public int score = 0;
    public static int money = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        moneyText.text = "Money: " + money.ToString();
    }

    void Update()
    {
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
