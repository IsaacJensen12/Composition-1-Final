using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumAnim : MonoBehaviour
{
    float accum;
    public float accumSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accum += Time.deltaTime * accumSpeed;
        transform.localPosition = new Vector3((2 * Mathf.Sin(accum) + .5f), (2 * Mathf.Cos(accum) + .5f), 0);
    }
}
