using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    public Transform transorm;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void SizePlus()
    {
        transform.localScale = new Vector3(10f, 10f, 1);
    }

    void SizeMinus()
    {

    }
}
