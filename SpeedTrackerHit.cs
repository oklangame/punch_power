using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrackerHit : MonoBehaviour
{
    private Vector3 lastPosition;
    //public Transform targetPositionR;
    public static float speedHitR;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
            speedHitR = (((transform.position - lastPosition).magnitude) / Time.deltaTime);
            lastPosition = transform.position; 
            
    }
}
