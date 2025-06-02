using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    Rigidbody2D rigid_body;

    void Start()
    {
        rigid_body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rigid_body.linearVelocity = new Vector2(horizontal * speed, vertical * speed);
    }
}

