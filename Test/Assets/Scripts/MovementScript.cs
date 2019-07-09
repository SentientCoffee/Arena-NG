using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed;
    public float jumpHeight;

    Rigidbody rb;
    Vector3 movement;
    bool isGrounded;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        movement = new Vector3(0.0f, 0.0f, 0.0f);

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        // Movement with WASD and/or arrow keys
        movement.Set(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        movement *= speed * Time.deltaTime;
        rb.transform.Translate(movement);

        if (Input.GetButtonDown("Jump")) {
            if (isGrounded) {
                rb.AddForce(Vector3.up * jumpHeight);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
        }

        isGrounded = false;
    }

    void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }

    //void OnCollisionExit(Collision other) {
    //    if (other.gameObject.tag == "Ground") {
    //        isGrounded = false;
    //    }
    //}
}
