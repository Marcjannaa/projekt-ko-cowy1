using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);

    }

    public static void PlayerDied()
    {
        SceneManager.LoadScene("Game");
    }

    public static void StartFight()
    {
        SceneManager.LoadScene("Battle");
    }
}
