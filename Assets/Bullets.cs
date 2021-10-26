using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float bulletSpeed;
    public bool isStopped = false;

    void Update()
    {
        transform.Translate(new Vector3(bulletSpeed, 0, 0));
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.layer == 12)
        {
            isStopped = true;
        }
    }
}
