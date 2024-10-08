using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클릭 시 점프
public class PlayerMove : MonoBehaviour
{
    // 중력 가속도
    [SerializeField] [Range(0, 10)] private float _gravity;

    // 점프력
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.gravityScale = _gravity;
    }

    private void Update()
    {
        // 마우스 왼쪽버튼 클릭 시
        if (Input.GetMouseButtonDown(0))
        {
            // 새의 로테이션을 45도로 고정
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
            Jump();
        }
        else
        {
            // 새의 로테이션을 -방향으로 감소
            transform.Rotate(new Vector3(0f, 0f, -90f) * Time.deltaTime);
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = Vector3.up * _jumpForce;
    }
}
