using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotAnim : MonoBehaviour
{
    public Transform oscObj;
    Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    
    void Update()
    {
        myLight.intensity = Mathf.PingPong(Time.time / 2, 3);
        float rotSpeed = 2 * oscObj.position.x + 2;
        transform.Rotate(0, rotSpeed, 0, Space.Self);
    }
}
