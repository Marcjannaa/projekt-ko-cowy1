using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameEnemy : MonoBehaviour
{
    
    public float speed = 5f;
    private Vector2 _moveDirection;

    private void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            Vector2 targetPosition = player.transform.position;
            Vector2 startPosition = transform.position;

            _moveDirection = (targetPosition - startPosition).normalized;
        }
        else
        {
            Debug.LogWarning("RocketEnemy: Gracz nie znaleziony! Upewnij się, że gracz ma tag 'Player'.");
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
        Debug.Log("Rakieta trafiła gracza!");

        if (GameManager.Instance != null)
        {
            GameManager.PlayerDied();
        }
        Destroy(gameObject);
    }
}


