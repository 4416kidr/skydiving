using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float DelayTime = 10f;
    public float DestroyTime = 1f;

    void DestroyObject() 
    {
        Destroy(this.gameObject, DestroyTime);
    }

    // Start is called before the first frame update
    void Start()
    {
         Invoke("DestroyObject", DelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
