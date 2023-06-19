using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    // Start is called before the first frame update
    Animator KeyAnim;
    void Start()
    {
       KeyAnim = GetComponent<Animator>();
       
       KeyAnim.SetBool("arda",false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){

        
        KeyAnim.SetBool("arda",true);
        Debug.Log("key çalıştı");
    }
}
