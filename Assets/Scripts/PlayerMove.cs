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
        transform.Rotate(new Vector3(0f, 0f, -90f) * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Jump();
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = Vector3.up * _jumpForce;
    }
}
