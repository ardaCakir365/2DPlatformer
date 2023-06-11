using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cheries : MonoBehaviour
{
    int CheeryCount=0;
    int BananaCount=0;

    [SerializeField]
    public TextMeshProUGUI cherryText;
    public TextMeshProUGUI bananaText;

    // Start is called before the first frame update
    void Start(){
      
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Cherry"){

            Debug.Log("cherry toplandı");
            cherryText.text = "cheeries "+ CheeryCount;
            CheeryCount++;
            Destroy(collision.gameObject); 
        }
        if(collision.gameObject.tag == "Banana"){

            Debug.Log("Banana toplandı!");
            bananaText.text = "banana "+ CheeryCount;
            BananaCount++;
            Destroy(collision.gameObject);
        }

    }


}
