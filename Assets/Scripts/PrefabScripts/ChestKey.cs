using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey : MonoBehaviour
{
    // Start is called before the first frame update
    Animator ChestAnim;
   // Animator KeyAnim;
    void Start()
    {
        ChestAnim = GetComponent<Animator>();
       // KeyAnim = GetComponentInChildren<Animator>();
        
       // ChestAnim.SetBool("KeyIsAnimating",false);
       ChestAnim.SetBool("ChestIsRunning",false);
    //   KeyAnim.SetBool("arda",false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(){

        //ChestAnim.SetBool("KeyIsAnimating",true);
        ChestAnim.SetBool("ChestIsRunning",true);
        Debug.Log("chestkey ontrigger worked");
      //  KeyAnim.SetBool("arda",true);
    }
}
