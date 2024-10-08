using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ŭ�� �� ����
public class PlayerMove : MonoBehaviour
{
    // �߷� ���ӵ�
    [SerializeField] [Range(0, 10)] private float _gravity;

    // ������
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.gravityScale = _gravity;
    }

    private void Update()
    {
        // ���콺 ���ʹ�ư Ŭ�� ��
        if (Input.GetMouseButtonDown(0))
        {
            // ���� �����̼��� 45���� ����
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
            Jump();
        }
        else
        {
            // ���� �����̼��� -�������� ����
            transform.Rotate(new Vector3(0f, 0f, -90f) * Time.deltaTime);
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = Vector3.up * _jumpForce;
    }
}
