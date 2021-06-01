using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    private Rigidbody rb;
    public float jumpspeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-jumpspeed, 0.0f);
        }
        else if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(jumpspeed, 0.0f);
        }
        else
        {
            rb.velocity = new Vector3(0.0f, 0.0f);
        }
    }
}
