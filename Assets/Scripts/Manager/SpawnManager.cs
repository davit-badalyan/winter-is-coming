using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int snowBallCount = 10;
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

    private void Start()
    {
        SpawnSnowballs();
    }

    private void Update()
    {
        //
    }
}
