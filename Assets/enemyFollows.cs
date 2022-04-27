using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollows : MonoBehaviour
{
    public float speed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.Rotate(0, 180, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // towards
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        // away
        transform.position = Vector2.MoveTowards(transform.position, target.position ,-1 * speed * Time.deltaTime);
    }
}