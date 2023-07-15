using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float fallGravity = 0.1f;
    public float moveGravity = 0.3f;
    public float timer = 0f;
    public float interval = 0.1f;
    public Vector3 nowSpeed = new Vector3(0.3f, 0.3f, 0.1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer = 0f;
            MoveCharacter();
        }
    }
    void MoveCharacter()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        nowSpeed = new Vector3(
            nowSpeed.x + horizontalInput*moveGravity, 
            nowSpeed.y + verticalInput*moveGravity, 
            nowSpeed.z + 0.5f*fallGravity);

        Vector3 newPosition = transform.position + nowSpeed;
        transform.position = newPosition;
    }
}
