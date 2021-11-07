using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb2d;
    public Animator animator;

    Vector2 movimiento;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(15,6,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer){
            return;
        }
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        movimiento.x = x;
        movimiento.y = y;
        animator.SetFloat("Horizontal", x); 
        animator.SetFloat("Vertical", y);
        animator.SetFloat("Speed", movimiento.sqrMagnitude);
        

        if(Mathf.Abs(x) >= Mathf.Abs(y)){
            y=0;
        }else if(Mathf.Abs(y) >= Mathf.Abs(x)){
            x = 0;
        }
        Vector2 movement = new Vector2(x , y) * speed ;
        rb2d.velocity = movement;
        
    }

    public override void OnStartLocalPlayer(){
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
