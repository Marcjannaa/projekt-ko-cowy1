using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private int enemyHp = 100;
    private List<GameObject> _enemies = new List<GameObject>();
    private void Awake()
    {
        foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            _enemies.Add(enemy);
            enemy.gameObject.SetActive(false);
        }
    }

    public void OnAttackClicked()
    {
        // dopisz logikę klikania Attack
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        // wrogowie się aktywują
        foreach (var enemy in _enemies)
        {
            enemy.gameObject.SetActive(true);
        }
    }
    
    public void OnMercyClicked()
    {
        // dopisz logikę klikania Mercy
        SceneManager.LoadScene("Game");
    }
    
}
