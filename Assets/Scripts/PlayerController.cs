using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Fixed update is used when manipulating physics
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        // Modify player velocity through rigidbody2d
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(horiz * speed, verti * speed);
    }
}
