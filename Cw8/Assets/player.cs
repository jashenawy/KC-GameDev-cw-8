using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class player : MonoBehaviour
{
    SpriteRenderer sprite;
    bool facinRight = true;

    Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
        playerAnimation();
    }
    void Flip()
    {
        if(facinRight == true && Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = true;
            facinRight = false;
        }
        else if (facinRight == false && Input.GetKeyDown(KeyCode.D))
        {
            sprite.flipX = false;
            facinRight = true;
        }
    }
      
    void playerAnimation()
    {
        float speed = Input.GetAxis("Horizontal");
        animation.SetFloat("Speed",Mathf.Abs(speed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animation.SetTrigger("Jump");
        } 


    }



}
  