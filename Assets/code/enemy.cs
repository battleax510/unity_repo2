using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int HP = 1;
    public int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(int damage)
    {
      HP = HP - damage;
        if(HP <= 0)
        {
           Destroy(gameObject);
        }
    }
}
