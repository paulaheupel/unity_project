using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Music : MonoBehaviour
{
    //Don't destroy the Background music, so that we have music in all following scenes
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
