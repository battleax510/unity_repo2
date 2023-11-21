using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_attack : MonoBehaviour
{
    public Animator swordAnime;
    public Animator anime;
    public BoxCollider2D BC2D;
    public BoxCollider2D BC2U;
    public BoxCollider2D BC2L;
    public BoxCollider2D BC2R;
    public int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            enemy hit = collision.GetComponent<enemy>();
            if(hit != null)
            {
                hit.takeDamage(damage);
            }
        }
    }

    public void attackDown()
    {
        BC2D.enabled = true;
    }
    public void attackUp()
    {
      BC2U.enabled = true;
    }
    public void attackLeft()
    {
      BC2L.enabled = true;  
    }
    public void attackRight()
    {
        BC2R.enabled = true;    
    }
    public void attackEnd()
    {
       BC2D.enabled = false;
       anime.SetTrigger("slash_end");
    }
}
