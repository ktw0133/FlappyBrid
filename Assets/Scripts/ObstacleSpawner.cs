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

            // y�� ��ǥ�� -2 ~ 3�� ��ֹ��� �����ϰ� ����
            spawnPos.y = Random.Range(-2f, 4f);
            
            GameObject newObstacle = Instantiate(_obstaclePrefab, spawnPos, transform.rotation);
            Destroy(newObstacle, 10.0f);

            // ��ֹ��� _minSpawnTime ~ _maxSpawnTime�� ���̿��� �����ϰ� ����
            _spawnTime = Random.Range(_minSpawnTime, _maxSpawnTime + 1);
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
