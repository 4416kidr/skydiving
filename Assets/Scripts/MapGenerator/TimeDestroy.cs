using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // public float DelayTime = 10f;
    public float DestroyTime = 1f;
    public GameObject Character;

    void DestroyObject() 
    {
        Destroy(this.gameObject, DestroyTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        //  Invoke("DestroyObject", DelayTime);
        Character = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Character.transform.position.z > transform.position.z)
        {
            DestroyObject();
        }
        
    }
}
