using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject PipeGameObject;
    public float spawnRate = 4;
    private float timer = 0;
    public float heigthOffSet = 4;
    

    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawner();
            timer = 0;
        }

    }

    void Spawner()
    {
        float lowestPoint = transform.position.y - heigthOffSet;
        float highestPoint = transform.position.y + heigthOffSet;

        Instantiate(PipeGameObject, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
        

    }
}
