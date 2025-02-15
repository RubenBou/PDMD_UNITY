using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float x, y;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal
        x = Input.GetAxis("Horizontal");
        // Movimiento vertical
        y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x , y)*speed;
    }
}
