using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We can quit the whole game with the escape key

public class QuitManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
