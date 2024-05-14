using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float camSpeed;
    
    private Rigidbody rb;
    private Camera cam;

    Vector2 dir = Vector2.zero;
    private float yRot = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (transform.forward * dir.y + transform.right * dir.x) * speed + rb.velocity.y * Vector3.up;
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(cam.transform.position, cam.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        else
        {
            Debug.DrawRay(cam.transform.position, cam.transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }
    }

    public void OnFire()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.GetComponent<TargetController>())
            {
                hit.collider.GetComponent<TargetController>().Break();
            }
        }
    }

    public void OnMove(InputValue inputValue)
    {
        dir = inputValue.Get<Vector2>();
    }

    public void OnLook(InputValue inputValue)
    {
        Vector2 input = inputValue.Get<Vector2>();
        transform.Rotate(Vector3.up, input.x * camSpeed);
        yRot = Mathf.Clamp(yRot - input.y * camSpeed, -60, 60);
        cam.transform.localEulerAngles = new Vector3(yRot, 0, 0);
    }
}
