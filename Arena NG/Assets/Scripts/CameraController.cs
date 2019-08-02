using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    private float mouseSensitivity = 4.0f;          // Mouse sensitivity for the camera
    [SerializeField]
    private GameObject player;                      // Reference for the player GameObject

    private float minX = -45.0f, maxX = 45.0f;      // Clamps to avoid 360 degree camera rotation in the x-axis
    private Rigidbody playerRB;                     // Player's Rigidbody reference
    private Vector3 cameraRotation;                 // To keep track of the current rotation of the camera

    // Start is called before the first frame update
    void Start() {
        // Check if we have a player GameObject, and retrieve its Rigidbody if it exists
        if(player != null) {
            playerRB = player.GetComponent<Rigidbody>();
        }

        // Make the cursor disappear when we start the game
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        // Calculate the camera rotation based on mouse input with mouse sensitivity
        Vector3 horizontalRotation = Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity;
        Vector3 verticalRotation = Vector3.right * Input.GetAxisRaw("Mouse Y") * mouseSensitivity;

        // Add to the camera rotation, and clamp the x-axis rotation if it goes above 45 degrees in either direction
        // This is to avoid "neck breaking" (into and behind the player)
        cameraRotation += horizontalRotation + verticalRotation;
        cameraRotation.x = Mathf.Clamp(cameraRotation.x, minX, maxX);

        // Check if we have a Rigidbody to rotate and if we have a rotation to apply in the y-axis
        if(playerRB != null && horizontalRotation != Vector3.zero) {
            // Apply the horizontal rotation to the entire player, including the camera
            playerRB.rotation = Quaternion.AngleAxis(cameraRotation.y, player.transform.up);
        }

        // Check if we have a rotation to apply in the x-axis
        if(verticalRotation != Vector3.zero) {
            // Apply the vertical rotation (which was already clamped) to ONLY the camera and its children
            transform.localRotation = Quaternion.AngleAxis(-cameraRotation.x, Vector3.right);
        }

        // If the escape key is pressed, make the cursor show up so that we can use it again
        if(Input.GetKeyUp(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
