using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmer;
    [SerializeField]
    private GameObject bigswarmer;
    [SerializeField]
    private GameObject Hunter;

    [SerializeField]
    private float swarmerInterval = 3.5f;
    [SerializeField]
    private float bigswarmerInterval = 10f;
    [SerializeField]
    private float hunterInterval = 15f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmer));
        StartCoroutine(spawnEnemy(bigswarmerInterval, bigswarmer));
        StartCoroutine(spawnEnemy(hunterInterval, Hunter));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-100f, 100), Random.Range(-100f, 100),0), Quaternion.identity);
        newEnemy.SetActive(true);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
