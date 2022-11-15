using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDecider : MonoBehaviour
{
    private float speed = 0.5f;
    private float RotSpd = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * (RotSpd * Time.deltaTime));
    }
}
