using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    public float sensitivity = 10.0f;
    public float smoothing = 2.0f;
    public float maxY = -45.0f, minY = 45.0f;

    Rigidbody playerRB;
    Vector3 mouseMovement;
    Vector3 mouseDelta;
    Vector3 smoothV;

    // Start is called before the first frame update
    void Start() {
        playerRB = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        mouseDelta = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"), 0.0f);
        mouseDelta *= sensitivity * smoothing;

        smoothV.x = Mathf.Lerp(smoothV.x, mouseDelta.x, 1.0f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mouseDelta.y, 1.0f / smoothing);
        smoothV.z = 0.0f;

        mouseMovement += smoothV;
        mouseMovement.y = Mathf.Clamp(mouseMovement.y, minY, maxY);

        transform.localRotation = Quaternion.AngleAxis(-mouseMovement.y, Vector3.right);
        playerRB.rotation = Quaternion.AngleAxis(mouseMovement.x, player.transform.up);
    }
}
