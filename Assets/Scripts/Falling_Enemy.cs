using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4f; 
    
    public AudioSource sound;

    void Update()
    {
        // Movement
        transform.Translate(Vector3.down * _enemySpeed * 0.007f);
       // Rotation
        transform.Rotate(0,100*Time.deltaTime,0);

    }

    private void OnTriggerEnter(Collider other)
    {
        // Damage player
        if (other.CompareTag("Player"))
        {
            sound.Play();
            Destroy(this.gameObject);
            other.GetComponent<Player>().Damage();
            
        }
    }
}
