using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCollision : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(target);
        }
    }
}
