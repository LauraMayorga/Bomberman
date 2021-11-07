using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.3f);
    }

    void Update(){
        //Animation
    }

    public void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.GetComponent<Fire>() == null){
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.GetComponent<Bomb>() != null){
            collision.gameObject.GetComponent<Bomb>().Explode();
        }
        
        
    }
}
