using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class asd : MonoBehaviour
{
    // Start is called before the first frame update
    Animator KeyAnim;
    Vector3 EndPosition;
    Renderer rendererr;
    Collider ab;

    public TextMeshProUGUI keyText;
    

    [SerializeField]
    GameObject DoorObject;
    public bool gotkey;

    void Start()
    {      
       keyText.text ="0";
       KeyAnim = GetComponent<Animator>();
       KeyAnim.SetBool("arda",false);
       EndPosition = transform.position + new Vector3(0,0.10f,0); 
       rendererr = GetComponent<Renderer>();
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag=="Player"){
              Debug.Log("keytext calisti");
        keyText.text ="1";
        DoorObject.tag ="Free";
        KeyAnim.SetBool("arda",true);
        Debug.Log("key çalıştı,anahtar toplandı");
            rendererr.sortingOrder = 1;
            transform.position = Vector3.MoveTowards(transform.position,EndPosition,5f);
        Destroy(this.gameObject);
        }
        

    }
}
