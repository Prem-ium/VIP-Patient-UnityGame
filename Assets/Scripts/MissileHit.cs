using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileHit : MonoBehaviour
{
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missile" || other.gameObject.tag == "Enemy")
        {
            explosion.Play();

            other.gameObject.tag = null;
              gameObject.tag = "Lights";
            //gameObject.tag = null;

            Destroy(other.gameObject);
            Destroy(gameObject, 10f);

        }
    }

}
