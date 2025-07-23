using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Rigidbody2D _rb;
    private Vector2 _moveInput;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _moveInput.x = Input.GetAxisRaw("Horizontal"); 
        _moveInput.y = Input.GetAxisRaw("Vertical");   

        _moveInput.Normalize(); 
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}
