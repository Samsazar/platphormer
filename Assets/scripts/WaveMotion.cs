using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMotion : MonoBehaviour
{
    public Vector2 moveVector;
    public float firstChange = 0;
    public float interval = 2;
    private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        InvokeRepeating("ChangeDirection", firstChange, interval);
        rbody.velocity = moveVector;
    }
    private void ChangeDirection()
    {
        moveVector = -moveVector;
        rbody.velocity = moveVector;
    }
}
