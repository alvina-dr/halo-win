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
    public int candyLoot = 10;
    GameObject noDestroy;
    SpriteRenderer enemySprite;


    void Start() {
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");
        //numberAllZombie = GameObject.FindGameObjectWithTag("Spawner").GetComponent<ZombiesSpawner>().zombies.Count;
        enemySprite = GetComponentInChildren<SpriteRenderer>();
    }

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
        if (collision.gameObject.layer == 7)
        {
            StartCoroutine(SufferIceAttack(collision));
        }
        if (collision.gameObject.layer == 8)
        {
            StartCoroutine(SufferThunderAttack(collision));
        }
                if (collision.gameObject.layer == 9)
        {
            StartCoroutine(SufferBombAttack(collision));
        }
    }

    IEnumerator Attack(Collider2D collision)
    {
        if (collision == null)
        {
            this.gameObject.GetComponentInChildren<Animator>().SetBool("animAttack", false);
            isStopped = false;
            //Debug.Log("GAME OVER");

        }
        else if (collision = GameObject.FindGameObjectWithTag("Treehouse").GetComponent<Collider2D>())
        {
            collision.gameObject.GetComponent<TreeHouse>().ReceiveDamage(attackDamage);
            this.gameObject.GetComponentInChildren<Animator>().SetBool("animAttack", true);
            yield return new WaitForSeconds(attackCooldown);
            StartCoroutine(Attack(collision));            
        }
    }

    IEnumerator SufferBombAttack(Collider2D collision)
    {
        if (collision == GameObject.Find("BombZone").GetComponent<Collider2D>()) {
            //enemySprite.color = new Color (1, 0, 0, 1); 
            ReceiveDamage(GameObject.Find("Powers").GetComponent<SpecialAttack>().bombDamage);
        } else {
            //enemySprite.color = new Color (1, 1, 1, 1); 
            yield return new WaitForSeconds(0);
        }
    }

    IEnumerator SufferIceAttack(Collider2D collision) {
        if (collision == GameObject.Find("IceZone").GetComponent<Collider2D>()) {
            ReceiveDamage(GameObject.Find("Powers").GetComponent<SpecialAttack>().iceDamage);
            speed = speed / 2;
            yield return new WaitForSeconds(5);
            speed = speed * 2;
            //devient bleu et animation
        } else  {
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator SufferThunderAttack(Collider2D collision) {
        if (collision == GameObject.Find("ThunderZone").GetComponent<Collider2D>()) {
            speed = speed / 10;
            ReceiveDamage(GameObject.Find("Powers").GetComponent<SpecialAttack>().thunderDamage);
            yield return new WaitForSeconds(1);
            ReceiveDamage(GameObject.Find("Powers").GetComponent<SpecialAttack>().thunderDamage);
            yield return new WaitForSeconds(1);
            speed = speed * 10;
            //et animation 
        } else {
            yield return new WaitForSeconds(1);
        }
    }


    public void ReceiveDamage(int damage)
    {
        if (health - damage <= 0)
        {
            transform.parent.GetComponent<SpawnPoint>().zombies.Remove(this.gameObject);
            noDestroy.GetComponent<CommonVariables>().addCandy(candyLoot);
            GameObject.FindGameObjectWithTag("Spawner").GetComponent<ZombiesSpawner>().numberZombieDead += 1;
            Destroy(this.gameObject);
        }
        else 
        {
            health = health - damage;
        }
    }
}

