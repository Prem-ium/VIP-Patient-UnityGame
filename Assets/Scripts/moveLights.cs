using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLights : MonoBehaviour
{
    public float rate = 80;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * rate * Time.deltaTime);
    }
}
