using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float Move;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void MoveRight()
    {
        transform.Translate(Move, 0.0f, 0.0f);
        /*float axis = Input.GetAxisRaw("Horizontal");
        Vector3 velocity = Vector3.right * axis * Move;
        _rb.velocity = velocity;*/
    }
    public void MoveLeft()
    {
        transform.Translate(-Move, 0.0f, 0.0f);
        /*float axis = Input.GetAxisRaw("Horizontal");
        Vector3 velocity = Vector3.left * axis * -Move;
        _rb.velocity = velocity;*/
    }

}
