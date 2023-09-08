using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinSpeed = 4.4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.08f, 0, 0 * (spinSpeed * Time.deltaTime));
    }
}
