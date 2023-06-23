using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    // Start is called before the first frame update
    Animator KeyAnim;
    Vector3 EndPosition;
    Renderer renderer;

    void Start()
    {
       KeyAnim = GetComponent<Animator>();
       KeyAnim.SetBool("arda",false);
       EndPosition = transform.position + new Vector3(0,0.10f,0); 
       renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame

    void OnTriggerEnter2D(){
        KeyAnim.SetBool("arda",true);
        Debug.Log("key çalıştı");
        renderer.sortingOrder = 1;
        transform.position = Vector3.MoveTowards(transform.position,EndPosition,5f);

    }
}
