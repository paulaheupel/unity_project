using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLeft : MonoBehaviour
{
    
    private float _bulletSpeed = 7f;

    void Update()
    {
        //Move bullet left
        transform.Translate(Vector3.left *_bulletSpeed * Time.deltaTime);

        //Destroy if certain X is reached 
         if(transform.position.x < -40f)
        {
            Destroy(this.gameObject);
        }
    }
}
