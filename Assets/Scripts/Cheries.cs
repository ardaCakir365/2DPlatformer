using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cheries : MonoBehaviour
{
    int CheeryCount=0;

    [SerializeField]
    public TextMeshProUGUI cherryText;
    // Start is called before the first frame update
    void Start(){
      
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Cherry"){

            Debug.Log("kod çalştı");
            cherryText.text = "cheeries "+ CheeryCount;
            CheeryCount++;
            Destroy(collision.gameObject);
        }
    }
}
