using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int Health;
    public int damagePerSec;
    public float speed;
    private bool isStopped;

    void FixedUpdate() 
    {
        if (!isStopped)
        {
            transform.Translate(new Vector3(speed * -1, 0, 0));    
        }
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.layer == 10)
        {
            isStopped = true;
        }
    }
}

