using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    public float speed;
    public float attackCooldown;
    public int attackDamage;
    private bool isStopped;

    void FixedUpdate() 
    {
        if (!isStopped)
        {
            transform.Translate(new Vector3(speed * -1, 0, 0)); 
            // transform.GetComponent<TreeHouse>().currentHealth = (currentHealth - attackDamage); => BERK
        }
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.layer == 10)
        {
            StartCoroutine(Attack(collision));
            isStopped = true;
        }
    }

    IEnumerator Attack(Collider2D collision)
    {
        if (collision == null)
        {
            Debug.Log("GAME OVER");
        }
        else
        {
            collision.gameObject.GetComponent<TreeHouse>().ReceiveDamage(attackDamage);
            yield return new WaitForSeconds(attackCooldown);
            StartCoroutine(Attack(collision));            
        }

    }

    public void ReceiveDamage(int damage)
    {
        if (health - damage <= 0)
        {
            transform.parent.GetComponent<SpawnPoint>().zombies.Remove(this.gameObject);
            Destroy(this.gameObject);
        }
        else 
        {
            health = health - damage;
        }
    }
}

