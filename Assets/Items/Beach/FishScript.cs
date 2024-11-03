using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public Rigidbody2D fish;
    public int min;
    public int max;
    public bool facingRight;

    public GameObject health;

    // Start is called before the first frame update
    public void Start()
    {
        fish.velocity = Vector2.right * 2;
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fish.transform.position.x > max) {
            fish.velocity = Vector2.left * 2;
        }
        else if(fish.transform.position.x < min) {
            fish.velocity = Vector2.right * 2;
        }

        Vector3 currScale = gameObject.transform.localScale;

        if (fish.velocity.x < 0 && facingRight)
        {
            currScale.x *= -1;
            facingRight = false;
        }
        else if(fish.velocity.x > 0 && !facingRight)
        {
            currScale.x *= -1;
            facingRight = true;
        }

        gameObject.transform.localScale = currScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            health.GetComponent<HealthScript>().takeDamage(10);
        }
    }
}
