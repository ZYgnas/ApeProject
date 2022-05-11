using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScritp : MonoBehaviour
{
    int sizeCount = 2;
    // Start is called before the first frame update
    public void SizePlus()
    {
        if (scoreManager.money >= 100)
        {
            transform.localScale = transform.localScale + new Vector3(.05f, .05f, 0);
            scoreManager.money -= 100;
            sizeCount++;
        }
    }

    // Update is called once per frame
    public void SizeMinus()
    {
        if (sizeCount > 0)
        {
            transform.localScale = transform.localScale + new Vector3(-.05f, -.05f, 0);
            scoreManager.money += 40;
            sizeCount--;
        }
    }
}
