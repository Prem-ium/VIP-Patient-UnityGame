using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 15f;
    private float maxPos = 9.7f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Possible bad idea?
        // Randomly generate values, if the value is completely divisible by 4 and 
        int num = (int)Random.Range(1f, 500f);
        if ((num % 4 == 0 && num % 3 == 0) || (num % 1 == 0 && num % 6 == 0))
        {
            speed += 1.5f;
        }
        */
        Vector3 bar = transform.position;

        // Rotate an enemy car, based on whether the randomly generated value was negative (on the left side of the road)

         if (bar.x >= 0)
         {
             transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
         }
         else
         {
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
         }
    }
}
