using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Main_Menu : MonoBehaviour
{
    // Load main game scene
    public void PlayGame()
    {
        Debug.Log("Load scene");
        SceneManager.LoadScene(1);
    }

}
