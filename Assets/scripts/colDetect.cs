using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colDetect : MonoBehaviour
{
    public Text score;
    private float Score = 0;
    public AudioClip deathClip;

    void Update()
    {
        score.text = "Points: " + Score.ToString();
    }
    //public Text score;
    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other) //this is commented
    {
        if (other.gameObject.tag != "EnemyHUNTER")
        {
            AudioSource.PlayClipAtPoint(deathClip, transform.position);
        }
        scoreManager.instance.AddPoints();
        other.gameObject.SetActive(false);
    }
}
