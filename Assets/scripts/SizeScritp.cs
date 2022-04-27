using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScritp : MonoBehaviour
{
    int sizeCount = 2;
    // Start is called before the first frame update
    public void SizePlus()
    {
        if (scoreManager.money >= 50)
        {
            transform.localScale = transform.localScale + new Vector3(.5f, .5f, 0);
            scoreManager.money -= 50;
            sizeCount++;
        }
    }

    // Update is called once per frame
    public void SizeMinus()
    {
        if (sizeCount > 0)
        {
            transform.localScale = transform.localScale + new Vector3(-.5f, -.5f, 0);
            scoreManager.money += 20;
            sizeCount--;
        }
    }
}
