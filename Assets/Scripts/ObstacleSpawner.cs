using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;

    [SerializeField] private float _spawnTime;

    private void Start()
    {
        StartCoroutine("SpawnObstacleCorutine");
    }
    private IEnumerator SpawnObstacleCorutine()
    {
        while (true)
        {
            Vector2 spawnPos = transform.position;
            GameObject newObstacle = Instantiate(_obstaclePrefab, spawnPos, transform.rotation);
            Destroy(newObstacle, 10.0f);

            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
