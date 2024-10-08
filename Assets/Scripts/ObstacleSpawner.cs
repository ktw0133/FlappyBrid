using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;

    [SerializeField] private float _minSpawnTime;
    [SerializeField] private float _maxSpawnTime;
    private float _spawnTime;

    private void Start()
    {
        StartCoroutine("SpawnObstacleCorutine");
    }

    private IEnumerator SpawnObstacleCorutine()
    {
        while (true)
        {
            Vector2 spawnPos = transform.position;

            // y축 좌표가 -2 ~ 3인 장애물을 랜덤하게 생성
            spawnPos.y = Random.Range(-2f, 4f);
            
            GameObject newObstacle = Instantiate(_obstaclePrefab, spawnPos, transform.rotation);
            Destroy(newObstacle, 10.0f);

            // 장애물이 _minSpawnTime ~ _maxSpawnTime초 사이에서 랜덤하게 스폰
            _spawnTime = Random.Range(_minSpawnTime, _maxSpawnTime + 1);
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
