using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    public float r=1000f;
    // Start is called before the first frame update
    void Start()
    {
        
            }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, r*Time.deltaTime);
    }
}
