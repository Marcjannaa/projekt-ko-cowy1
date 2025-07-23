using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameEnemy : MonoBehaviour
{
    
    public float speed = 5f;
    private Vector2 _moveDirection;
    private Vector2 _startPos;
    
    private void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        _startPos = gameObject.transform.position;
        
        if (player != null)
        {
            Vector2 targetPosition = player.transform.position;
            Vector2 startPosition = transform.position;

            _moveDirection = (targetPosition - startPosition).normalized;
        }
        else
        {
            _moveDirection = Vector2.right; 
        }
    }

    private void Update()
    {
        transform.Translate(_moveDirection * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        if (GameManager.Instance != null)
        {
            GameManager.PlayerDied();
        }
        Destroy(gameObject);
    }
    
    
}


