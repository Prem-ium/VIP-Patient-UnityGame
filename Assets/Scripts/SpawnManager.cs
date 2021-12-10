using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyCars;
    public GameObject animal;
    private float maxPosition = 9.7f;
    private float midPoint;
    private float delayTimer = 1.5f;
    float timer;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
        midPoint = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            
            float pos = Random.Range(-maxPosition, maxPosition);
            int enemyIndex = Random.Range(0, enemyCars.Length);


            if (pos < midPoint && pos > -midPoint )
            {
                pos = Random.Range(-maxPosition, maxPosition);
            }

            if (pos > 0)
            {
                position = new Vector3(Random.Range(midPoint, maxPosition), transform.position.y, transform.position.z);
            }
            
            if (pos < 0)
            {
                //transform.RotateAround(transform.position, transform.up, -180f);
                transform.Rotate(0, 180f, 0, Space.Self);
                position = new Vector3(Random.Range(-maxPosition, -midPoint), transform.position.y, transform.position.z);
            }
            
            Instantiate(enemyCars[enemyIndex], position, transform.rotation);

            timer = delayTimer;
        }
    }
}
