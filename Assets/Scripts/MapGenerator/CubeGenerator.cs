using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float interval = 1f;
    public float zInterval = 1f;
    public float nowZPos = 10f;
    private float timer = 0f;

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
            nowZPos += 1;
            GenerateObject(nowZPos);
        }
    }
    void GenerateObject(float zPos)
    {
        float xPos = Random.Range(-5f, 5f);
        float yPos = Random.Range(-5f, 5f);
        Vector3 position = new Vector3(xPos, yPos, zPos);
        Quaternion rotation = Quaternion.identity;
        Instantiate(prefab, position, rotation);
    }
}
