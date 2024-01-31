using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject gameManager;
    private string[] sceneName = { "MainMenu", "MainLevel" };
    private int sceneIndex = 0;
    public bool newGame;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = GameObject.Find("GameManager");
            DontDestroyOnLoad(gameManager);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }

    // Change Level By Index
    public void ChangeScene(int sceneIndex)
    {
        if (sceneIndex < sceneName.Length && sceneIndex >= 0)
        {
            this.sceneIndex = sceneIndex;
            SceneManager.LoadScene(sceneName[this.sceneIndex]);
        }
        else
            throw new Exception("Level specified " + sceneIndex + " in ChangeScene(int) does not exist!");
    }

    // Change Level By Name
    public void ChangeScene(string sceneName)
    {
        for (int i = 0; i < this.sceneName.Length; i++)
        {
            if (this.sceneName[i] == sceneName)
            {
                SceneManager.LoadScene(sceneName);
                return;
            }
        }

        throw new Exception("Level specified " + sceneName + " in ChangeScene(string) does not exist!");
    }

    // Auto Change Scene
    public void ChangeScene()
    {
        int sceneIndex = this.sceneIndex + 1;
        sceneIndex++;
        if (sceneIndex < sceneName.Length && sceneIndex >= 0)
        {
            this.sceneIndex = sceneIndex;
            SceneManager.LoadScene(sceneName[this.sceneIndex]);
        }

        else
            throw new Exception("Level specified " + this.sceneIndex + " in ChangeScene() does not exist!");
    }

    public void SetNewGameBool(bool newGame)
    {
        this.newGame = newGame;
    }
}
