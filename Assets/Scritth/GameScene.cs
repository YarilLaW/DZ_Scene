using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    [SerializeField] private Sprite _gamescene;

    private const int IndexMenuScene = 2;

    public void StartButtonMenu()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(IndexMenuScene);
        }
    }
}
