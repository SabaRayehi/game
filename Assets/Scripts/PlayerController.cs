using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementS = 5f;
    float move = 0f;
    Rigidbody2D rigib;
   

    // Start is called before the first frame update
    void Start()
    {
        rigib = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal") * movementS;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rigib.velocity;
        velocity.x = move;
        rigib.velocity = velocity;
    }
}
