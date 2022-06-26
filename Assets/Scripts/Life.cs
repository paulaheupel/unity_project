using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private int lives; 

    public AudioSource sound;

    // Call health function when collecting lives
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().Health();
            Destroy(this.gameObject);
            sound.Play();
            
        }
    }
}
