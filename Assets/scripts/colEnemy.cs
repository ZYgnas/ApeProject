using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colEnemy : MonoBehaviour
{
    public AudioClip deathClip;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "player")
        {
            AudioSource.PlayClipAtPoint(deathClip, transform.position);
            other.gameObject.SetActive(false);
        }
    }
}
