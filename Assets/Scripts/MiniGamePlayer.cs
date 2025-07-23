using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Rigidbody2D _rb;
    private Vector2 _moveInput;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _moveInput.x = Input.GetAxis("Horizontal"); 
        _moveInput.y = Input.GetAxis("Vertical");   
        _moveInput.Normalize(); 
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _moveInput * (moveSpeed * Time.fixedDeltaTime));
    }
}
