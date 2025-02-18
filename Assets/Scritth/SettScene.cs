using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SettScene : MonoBehaviour
{
    [SerializeField] private Sprite _sett;

    private const int IndexBaseScene = 0;

    public void StartButtonBase()
    {
        SceneManager.LoadScene(IndexBaseScene);
    }
}
