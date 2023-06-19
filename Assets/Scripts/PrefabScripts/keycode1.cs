using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycode1 : MonoBehaviour
{
    Animator KeyAnim;
    Vector3 StartPosition;
    void Start()
    {
       KeyAnim = GetComponent<Animator>();
       StartPosition = transform.position;
       KeyAnim.SetBool("arda",false);
        
    }

    // Update is called once per frame

    void OnTriggerEnter2D(){
        KeyAnim.SetBool("arda",true);
        Debug.Log("key çalıştı");
    

    }
}


