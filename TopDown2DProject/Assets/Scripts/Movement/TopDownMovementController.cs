using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _body;

    private float _horizontal;
    private float _vertical;
    private float _moveLimiter = 0.7f;

    [SerializeField] private float _runSpeed;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (_horizontal != 0 && _vertical != 0)
        {
            _horizontal *= _moveLimiter;
            _vertical *= _moveLimiter;
        }

        _body.velocity = new Vector2(_horizontal * _runSpeed, _vertical * _runSpeed);
    }
}
