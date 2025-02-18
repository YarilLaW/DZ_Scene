using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private Sprite _menu;

    private const int IndexBaseScene = 0;
    private const int IndexGameScene = 1;
    private const int IndexSettScene = 3;

    public void StartButtonBase()
    {
        SceneManager.LoadScene(IndexBaseScene);
    }

    public void StartButtonGame()
    {
        SceneManager.LoadScene(IndexGameScene);
    }

    public void StartButtonSett()
    {
        SceneManager.LoadScene(IndexSettScene);
    }
}
