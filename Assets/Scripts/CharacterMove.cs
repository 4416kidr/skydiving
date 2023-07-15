using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float fallSpeed = 0.1f;
    public float moveSpeed = 0.3f;
    private float timer = 0f;
    private float interval = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer = 0f;
            MoveCharacter(horizontalInput, verticalInput);
        }
    }
    void MoveCharacter(float hi, float vi)
    {
        Vector3 newPosition = transform.position + new Vector3(hi*moveSpeed, vi*moveSpeed, fallSpeed);
        transform.position = newPosition;
    }
}
