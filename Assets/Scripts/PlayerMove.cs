using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] private float _gravity;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.gravityScale = _gravity;
    }

    private void Update()
    {
        // 아무것도 하지 않을 시 새의 로테이션을 -방향으로 계속 감소
        transform.Rotate(new Vector3(0f, 0f, -90f) * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Jump();
            // 새의 로테이션을 45도로 고정
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = Vector3.up * _jumpForce;
    }
}
