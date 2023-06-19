using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    Animator DoorAnim;    
   void Start()
    {
        DoorAnim = GetComponent<Animator>();
        DoorAnim.SetBool("PlayerEntered",false);
        DoorAnim.SetBool("KeepIdle",false);
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D collision){
        DoorAnim.SetBool("PlayerEntered",true);
        DoorAnim.SetBool("KeepIdle",true);
        
        //SceneManager.LoadScene();

    }
     public void OnAnimationComplete(Animator.)
    {
        // Code to change animator parameter
        DoorAnim.SetBool("MyParameter", true);
    }
}
