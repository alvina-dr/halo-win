using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float bulletSpeed;
    public int DamageValue;
    public bool isStopped = false;

    void Update()
    {
        transform.Translate(new Vector3(bulletSpeed, 0, 0));
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.layer == 11)
        {
            collision.gameObject.GetComponent<EnemyController>().ReceiveDamage(DamageValue);
            Destroy(this.gameObject);
        }
    }
}
