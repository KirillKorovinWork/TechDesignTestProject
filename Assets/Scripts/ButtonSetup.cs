using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSetup : MonoBehaviour
{
    

    [SerializeField] int sceneToLoad;
    public void SceneLoader()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
