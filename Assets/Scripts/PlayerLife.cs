using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public GameObject other;
    public float damage;
    public GameObject gHealthBar;
    

    private void Start()
    {
        gHealthBar = GameObject.FindWithTag("HealthBar");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
      //  other.gameObject.
      damage = 10;
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Traps"))
        {
            
            Die();
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }


    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void UpdateHealth(float damage){
        //float CurrentHealth = gHealthBar.;
       // gHealthBar.value =CurrentHealth - damage;
    }
}
