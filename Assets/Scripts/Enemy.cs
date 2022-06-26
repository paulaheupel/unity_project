using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioSource sound;

    public AudioSource enemyDeath;

    [SerializeField]
    float bounceForce;

    [SerializeField]
    string PlayerTag;

    // Damge when player and enemy collide
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            sound.Play();
            other.GetComponent<Player>().Damage();

            // Player bounces back from enemy
             other.GetComponent<Rigidbody>().AddExplosionForce(bounceForce, transform.position,1);
        }
        
        // Destroy enemy and bullet when they collide
        if (other.CompareTag("Bullet"))
        {
            enemyDeath.Play();
            Destroy(this.gameObject);
            Destroy(other.gameObject);

        }
    }

    // Bounce back from enemy
    void OnCollisionEnter(Collision collision){
        if(collision.transform.tag == PlayerTag)
        {
            Rigidbody otherRB = collision.rigidbody;
            otherRB.AddExplosionForce(bounceForce, collision.contacts[0].point, 5);
        }
    }
    
}
