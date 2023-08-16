using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerDamage : MonoBehaviour
{
    private Collider2D coll;
    [SerializeField]
    float PushMagnitude =10;

    //public GameObject deathEffect;


    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("carpısma Algılandı!");
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("carpısma Player İle yapıldı");

            Vector2 asd = collision.relativeVelocity;
            asd = asd*(PushMagnitude);
            collision.rigidbody.AddForce(new Vector3(10,10,10),ForceMode2D.Force);
            Debug.Log("is" + asd);
            //HealthReduce();
            //CheckLife();
        }
    }

}
  