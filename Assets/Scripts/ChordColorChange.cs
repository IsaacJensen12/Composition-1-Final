using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordColorChange : MonoBehaviour
{
    Material mat;
    public Transform oscObj;
    public Transform oscObj2;
    public Transform oscObj3;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float ChordPitch = ((oscObj.position.x + .25f * 2f) + (oscObj2.position.x + .25f * 1.5f) + (oscObj3.position.x + .25F));
        mat.SetFloat("_Hue", ChordPitch);
    }
}
