using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collected : MonoBehaviour
{
    int CheeryCount=0;
    int BananaCount=0;
    int AnanasCount=0;
    int KeyCount;

    [SerializeField]
    public TextMeshProUGUI cherryText;
    public TextMeshProUGUI bananaText;
    public TextMeshProUGUI AnanasText;


    GameObject Object0,Object1,Object2;
    public TextMeshProUGUI keyText;

    // Start is called before the first frame update
    void Start(){
      Object0 = GameObject.FindGameObjectWithTag("CherryText");
      Object1 = GameObject.FindGameObjectWithTag("AnanasText");
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Cherry"){

            Debug.Log("cherry toplandı");
            cherryText.text = "cheeries "+ CheeryCount;
            CheeryCount++;
            Destroy(collision.gameObject); 
            cherryText=Object0.GetComponent<TextMeshProUGUI>();
            cherryText.text =CheeryCount +"";
        }
        if(collision.gameObject.tag == "Banana"){

            Debug.Log("Banana toplandı!");
            bananaText.text = "banana "+ CheeryCount;
            BananaCount++;
            Destroy(collision.gameObject);
        }if(collision.gameObject.tag=="Ananas"){
            Debug.Log("anans toplandı");
            AnanasText=Object2.GetComponent<TextMeshProUGUI>();
            AnanasText.text =AnanasCount+"";
            
            Destroy(collision.gameObject);


        }
            if(collision.gameObject.tag == "Key"){

            Debug.Log("key toplandı");
            keyText.text = "key "+ CheeryCount;
            KeyCount++;
            Destroy(collision.gameObject); 
        }

    }


}
