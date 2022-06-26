using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5f; 

    [SerializeField]
    private Rigidbody RB;

    private float _jumpingSpeed = 9f;

    private float _coolDownTime = 1f;
    private float _nextJumpTime = 0f;

    private int _lives = 3; 

    [SerializeField]
    private UI_Manager _uiManager;

    [SerializeField]
    private GameObject BulletRight; 

    [SerializeField]
    private GameObject BulletLeft; 

    public AudioSource sound;

    public AudioSource fire;

    public Coin coin;

    private bool isRight; 

    // Initialize player (position, lives, orientation)
    void Start()
    {
        transform.position = new Vector3(-10f, 0f, 0f);
        _uiManager.UpdateLife(_lives);
        isRight = true;
    }

    void Update()
    {
        //Movement
        float horizontalInput = Input.GetAxis("Horizontal");
     
        // Facing the palyer in the right direction 

        // Look to the right
        if (horizontalInput > 0)
        {
            transform.localRotation= Quaternion.Euler(0,0,0);
            transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalInput);
            isRight = true;
        }

        // Look to the left
        if (horizontalInput < 0)
        {
            transform.localRotation= Quaternion.Euler(0,180,0);
            transform.Translate(Vector3.left * Time.deltaTime * _speed * horizontalInput);
            isRight = false;
        }
    
        // Jumping
        if (Input.GetKeyDown("space") && _nextJumpTime < Time.time)
        {
            RB.velocity += new Vector3(0f, _jumpingSpeed, 0f);
            _nextJumpTime = Time.time + _coolDownTime;
            sound.Play();
        }

         // Spawn bullet when F is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Instantiate bullet in the right direction
            if (isRight)
            {
                Instantiate(BulletRight, transform.position, Quaternion.identity);
            }
            else 
            {
                Instantiate(BulletLeft, transform.position, Quaternion.identity);
            }

            fire.Play();
        }

         // Game over when falling from the last platform
        if(transform.position.y < -10)
        {
            Destroy(this.gameObject);
            coin.OnDeath();
        }
    }

    // Decrease lives when damaged
    public void Damage()
    {
        _lives --;
        _uiManager.UpdateLife(_lives);

        if(_lives == 0)
        {
            Destroy(this.gameObject);
            coin.OnDeath();
        }

    }

    // Increase lives when collecting hearts
    public void Health()
    {
        _lives +=1;
        _uiManager.UpdateLife(_lives);

    } 
}