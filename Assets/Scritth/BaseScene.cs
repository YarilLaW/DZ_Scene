using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BaseScene : MonoBehaviour
{ 
    [SerializeField] private Sprite _base;

    private const int IndexBaseScene = 0;
    private const int IndexGameScene = 1;
    private const int IndexMenuScene = 2;
    private const int IndexSettScene = 3;

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Выход");
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
