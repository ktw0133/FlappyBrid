using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x -= _speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
