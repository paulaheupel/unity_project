using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRight : MonoBehaviour
{
    private float _bulletSpeed = 7f;

    void Update()
    {
        //Move bullet right
        transform.Translate(Vector3.right *_bulletSpeed * Time.deltaTime);

        //Destroy if certain X is reached
        if(transform.position.x > 40f)
        {
            Destroy(this.gameObject);
        }
    }
}
