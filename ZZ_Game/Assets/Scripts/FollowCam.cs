using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform ballPosition;
    Vector3 difference;

    // Start is called before the first frame update
    void Start()
    {
        difference = transform.position - ballPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (BallMovement.fell == false)
        {
            transform.position = ballPosition.position + difference; 
        }
  
    }
}
