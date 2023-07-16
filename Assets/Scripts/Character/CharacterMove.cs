using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float teleportZPosition = 100f;
    public float gravityScale = 1.0f;
    private float gravityStrength = 9.8f;
    private Vector3 gravityDirection = Vector3.right;
    private Rigidbody body;
    private int collisionCount = 0;
    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().freezeRotation = true;
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        gravityDirection = new Vector3(horizontalInput, verticalInput, 1f);
        body.AddForce(gravityDirection * gravityStrength * gravityScale);

        if (transform.position.z >= teleportZPosition)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 relativePoint = transform.InverseTransformPoint(collision.contacts[0].point);
        if (relativePoint.z >= 0.4)
        {
            collisionCount += 1;
            Debug.Log($"{collisionCount}");
        }
        Debug.Log($"{relativePoint}");
    }
}
