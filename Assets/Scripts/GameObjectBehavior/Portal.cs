using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ChangeScene(2);
    }

    public void ChangeScene(int sceneIndex)
    { 
            SceneManager.LoadScene(sceneIndex);
    }
}
