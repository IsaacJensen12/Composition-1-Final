using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumAnim2 : MonoBehaviour
{
    public Transform oscObj;
    Material mat;
    float accumSpeed = 1;
    float accum;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        accum += oscObj.position.x  * Time.deltaTime * accumSpeed;
        mat.SetFloat("_AngleOffset", accum);

    }
}
