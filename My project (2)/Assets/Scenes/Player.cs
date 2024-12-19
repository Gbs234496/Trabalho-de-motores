using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 public float velocidade = 10f;
 public float focaPulo = 10f;
    
    public bool noChão = false;

    
 private Rigidbody2D _rigidbody2D;
 private SpriteRenderer;

    // Update is called once per frame
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


     void OnCollisionStay2D(Collison2D collsion)
    {
          if (collison.gameObject.tag == "chão")
          {
              noChao = true;
          }

    }

    void OncollisionExit2D(Collision2D collison)
    {
        if (collision.gameObject.tag == "chao")
          {
              noChao = false;
          }
    }
    void Update()
    {
        if(Input.Getkey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);
            spriteRenderer.flipX = true;
            Debug.log("LeftArrow");
        }


        if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
            spriteRenderer.flipX = false;
            Debung.log("RightArrow");
        }

         if(Input.Getkey(KeyCode.Space) && noChao  == true)
         {
               _rigidbody2D.AddForce(new Vector(0,1))
         }
    }
}
