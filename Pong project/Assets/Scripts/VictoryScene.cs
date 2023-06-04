using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    private void Start()
    {
        Invoke("loadMainMenu", 3);
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
