using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colDetect : MonoBehaviour
{
    public Text score;
    public Text money;
    float Score = 0;
    float Money = 0;

    void Update()
    {
        score.text = "Points: " + Score.ToString();
        money.text = "Money: " + Money.ToString();
    }
    //public Text score;
    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other)
    {
        Score += 50;
        Money += 25;
        other.gameObject.SetActive(false);
    }
}
