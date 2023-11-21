using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5;
    public Animator anime;
    bool faceingUp = false;
    bool faceingDown = true;
    bool faceingRight = false;
    bool faceingLeft = false;
    public Sword_attack SA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            swingSword();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            anime.SetBool("direction_left", false);
            anime.SetBool("direction_right", true);
            anime.SetBool("direction_down", false);
            anime.SetBool("direction_up", false);
            anime.SetBool("movement", true);
            faceingRight = true;
            faceingLeft = false;
            faceingUp = false;
            faceingDown = false;
        }
         else if (Input.GetKey(KeyCode.A))
         {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            anime.SetBool("direction_right", false);
            anime.SetBool("direction_down", false);
            anime.SetBool("direction_up", false);
            anime.SetBool("direction_left", true);
            anime.SetBool("movement", true);
            faceingRight = false;
            faceingLeft = true;
            faceingUp = false;
            faceingDown = false;
        }

         else if (Input.GetKey(KeyCode.W))
         {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            anime.SetBool("direction_down", false);
            anime.SetBool("direction_up", true);
            anime.SetBool("direction_right", false);
            anime.SetBool("direction_left", false);
            anime.SetBool("movement", true);
            faceingRight = false;
            faceingLeft = false;
            faceingUp = true;
            faceingDown = false;
        }
         else if (Input.GetKey(KeyCode.S))
         {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
            anime.SetBool("direction_down", true);
            anime.SetBool("direction_up", false);
            anime.SetBool("direction_right", false);
            anime.SetBool("direction_left", false);
            anime.SetBool("movement", true);
            faceingRight = false;
            faceingLeft = false;
            faceingUp = false;
            faceingDown = true;
        }
         else
         {
            anime.SetBool("movement", false);
         }
    }
    public void swingSword()
    {
        anime.SetTrigger("slash");
      if(faceingDown == true)
      {
            SA.attackDown();
      }
      else if(faceingUp == true)
      {
        SA.attackUp();
      }
      else if(faceingLeft == true)
      {
         SA.attackLeft();
      }
      else if(faceingRight == true)
        {
            SA.attackRight();
        }
    }
    public void attackEnd()
    {
        SA.attackEnd();
    }
}
