using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public int amount = 10;
    public float delay = 2;

    private IEnumerator coroutine;

    void Start()
    {
        coroutine = WaitAndSpawn(delay);
        StartCoroutine(coroutine);
    }

    // every 2 seconds perform the print()
    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while (amount > 0)
        {
            yield return new WaitForSeconds(waitTime);
            amount--;
            GameObject clone = Instantiate(enemy);
            clone.transform.position = transform.position;
            clone.SetActive(true);
        }
    }
}
