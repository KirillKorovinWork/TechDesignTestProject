using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSetup : MonoBehaviour
{
    private Button button;
    private int itemCount;
    [SerializeField] int sceneToLoad;

    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        //Count and check items and enable the button
        itemCount = GameObject.FindGameObjectsWithTag("item").Length;

        if (itemCount <= 0)
        {
            button.interactable = true;
        }
    }

    public void SceneLoader()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
