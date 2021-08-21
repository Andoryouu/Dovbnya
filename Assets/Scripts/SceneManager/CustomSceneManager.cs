using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    public void ChangeScene(int _sceneNum)
    {
        SceneManager.LoadScene(_sceneNum);
    }
}
