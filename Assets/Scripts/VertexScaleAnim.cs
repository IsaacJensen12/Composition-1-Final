using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexScaleAnim : MonoBehaviour
{
    Material mat;
    public Transform oscObj;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float Scale = oscObj.position.x - 5;
        mat.SetFloat("_Scale", Scale);
    }
}
