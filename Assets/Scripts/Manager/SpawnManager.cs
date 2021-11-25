using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int enemyCount = 5;
    public int snowBallCount = 20;
    public GameObject enemyPrefab;
    public GameObject enemyParent;
    public GameObject snowBallPrefab;
    public GameObject snowBallsParent;

    public void SpawnSnowballs()
    {
        for (int i = 0; i < snowBallCount; i++)
        {
            Vector3 position = new Vector3(Random.Range(-45.0F, 45.0F), 3.0f, Random.Range(-45.0F, 45.0F));
            Instantiate(snowBallPrefab, position, Quaternion.identity, snowBallsParent.transform);
        }
    }
    public void SpawnEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 position = new Vector3(Random.Range(-45.0F, 45.0F), 3.0f, Random.Range(-45.0F, 45.0F));
            Instantiate(enemyPrefab, position, Quaternion.identity, enemyParent.transform);
        }
    }

    private void Start()
    {
        SpawnSnowballs();
        SpawnEnemies();
    }

    private void Update()
    {
        //
    }
}
