using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour

{
    public float jump = 8f;

    // Start is called before the first frame update
   

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rigib = collision.collider.GetComponent<Rigidbody2D>();
            if (rigib != null)
            {
                Vector2 velocity = rigib.velocity;
                velocity.y = jump;
                rigib.velocity = velocity;
            }
        }
    }
}
