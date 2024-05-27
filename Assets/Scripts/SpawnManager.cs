using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float maxTime = 2.5f;
    [SerializeField] private float heightRange = 0.55f;
    [SerializeField] private GameObject obstaclePrefab;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }
    private void SpawnObstacle()
    {
        Vector3 spawnPos = transform.position + new Vector3(3, Random.Range(-heightRange, heightRange));
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        Destroy(obstacle, 10f);
    }
    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            SpawnObstacle();
            timer = 0;
        }
        timer += Time.deltaTime; // timer = timer + 0.0001
    }
}
