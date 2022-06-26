using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Moon : MonoBehaviour
{
    // Let the moon rotate
    void Update()
    {
        transform.Rotate(new Vector3(0f,7f,0f)* Time.deltaTime);
    }

    // Load next scene when player jumps against the moon
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
