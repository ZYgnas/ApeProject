using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colDetect : MonoBehaviour
{
    public Text score;
    private float Score = 0;

    void Update()
    {
        score.text = "Points: " + Score.ToString();
    }
    //public Text score;
    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other)
    {
        scoreManager.instance.AddPoints();
        other.gameObject.SetActive(false);
    }
}
