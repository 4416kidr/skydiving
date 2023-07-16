using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject capsule;
    public GameObject cube;
    public GameObject sphere;
    public GameObject[] objectsList;

    public float interval = 0.01f;
    public float zInterval = 1f;
    public float nowZPos = 10f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        objectsList = new GameObject[3];
        objectsList[0] = capsule;
        objectsList[1] = cube;
        objectsList[2] = sphere;
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
        int randomNamber = Random.Range(0, 3);
        float xPos = Random.Range(-5f, 5f);
        float yPos = Random.Range(-5f, 5f);
        Vector3 position = new Vector3(xPos, yPos, zPos);
        Quaternion rotation = Quaternion.identity;
        GameObject childObject = Instantiate(objectsList[randomNamber], position, rotation);
        childObject.transform.parent = transform;
    }
}
