using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public Animator DoorAnim,animator;    
   void Start()
    {
        DoorAnim = GetComponent<Animator>();
        DoorAnim.SetBool("PlayerEntered",false);
        DoorAnim.SetBool("KeepIdle",false);
    }
        private bool IsAnimationPlaying(string animationName)
    {
        if (animator == null)
        {
            Debug.LogWarning("Animator component is not assigned.");
            return false;
        }

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.IsName(animationName) && stateInfo.normalizedTime < 1f;
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D collision){
        DoorAnim.SetBool("PlayerEntered",true);
        DoorAnim.SetBool("KeepIdle",true);
        
        //SceneManager.LoadScene();

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("onTriggerStay metodu çalışıyor");
        
        if (IsAnimationPlaying("DoorOpenedIdle"))
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
            Debug.Log("New scene loaded! Scene index: " + nextSceneIndex);
        }
    }
    }
    


