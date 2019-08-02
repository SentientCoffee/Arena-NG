using UnityEngine;

[RequireComponent(typeof(Rigidbody))]              // For this script to work, a Rigidbody must be present on the GameObject this script is attached to
public class PlayerController : MonoBehaviour {
    [SerializeField]
    private float speed = 5.0f;                    // Speed factor (can be modified in editor)

    private Vector3 velocity = Vector3.zero;       // Final velocity vector that will move the player
    private Rigidbody rb;                          // Reference to player's rigidbody component

    void Start() {
        // Get the player's rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        // Calculate movement vector
        Vector3 moveX = Input.GetAxisRaw("Horizontal") * transform.right;
        Vector3 moveZ = Input.GetAxisRaw("Vertical") * transform.forward;
        velocity = (moveX + moveZ).normalized * speed;
    }

    void FixedUpdate() {
        // Check if the player is supposed to move
        if(velocity != Vector3.zero) {
            // Move the player accordingly (apply movement vector)
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
}
