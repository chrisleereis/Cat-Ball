using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator flip;
    public bool facingLeft;
    
    
    // Start is called before the first frame update
    void Start()
    {
        flip = GetComponent<Animator>();
        facingLeft = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (facingLeft)
            {
                flip.enabled = false;
                return;
            }
            else
            {
                flip.enabled = true;
                flip.Play("Base Layer.TurnLeft");
                transform.localScale = new Vector3(2, 1, 1);
                facingLeft = true;
                return;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!facingLeft)
            {
                flip.enabled = false;
                return;
            }
            else
            {
                flip.enabled = true;
                flip.Play("Base Layer.TurnRight");
                transform.localScale = new Vector3(-2, 1, 1);
                facingLeft = false;
                return;
            }
        }


    }
}
