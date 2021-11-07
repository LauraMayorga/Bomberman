using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb2d;
    public Animator animator;

    Vector2 movimiento;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
}
