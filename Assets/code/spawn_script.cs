using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{
    public GameObject demon;
    public GameObject stoneGuy;
    public float spawnRate = 3;
    float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (count < spawnRate)
        {
          count = count + Time.deltaTime;
        }
        else
        {
            Instantiate(demon, new Vector2(-12.85f, 8.97f), transform.rotation);
            Instantiate(stoneGuy, new Vector2(11.72f, 9.03f), transform.rotation);
            count = 0;
        }
    }
}
