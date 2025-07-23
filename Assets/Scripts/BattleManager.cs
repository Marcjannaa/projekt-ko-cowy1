using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public void OnAttackClicked()
    {

    }
    
    public void OnMercyClicked()
    {
        SceneManager.LoadScene("Game");
    }

}
