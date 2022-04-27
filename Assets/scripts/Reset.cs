using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public void RESET()
    {
        scoreManager.score = 0;
        scoreManager.money = 0;
        Movement.moveSpeed = 15f;
        this.gameObject.SetActive(true);
        transform.localScale = new Vector3(0.9405661f, 0.9825784f, 1);
    }
}
