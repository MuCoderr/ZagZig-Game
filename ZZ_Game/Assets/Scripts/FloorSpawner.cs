using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject end_floor;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<20; i++)
        {
            floor_spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void floor_spawn()
    {
        Vector3 direction;
        if (Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else    
        {
            direction = Vector3.forward;
        }
        end_floor = Instantiate(end_floor, end_floor.transform.position + direction, end_floor.transform.rotation);
    }
}
