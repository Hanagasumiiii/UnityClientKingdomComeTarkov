using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float angularSpeed = 180f;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        
        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        
        transform.Translate(movement, Space.World);
        
        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, angularSpeed * Time.fixedDeltaTime);
        }
    }
}
