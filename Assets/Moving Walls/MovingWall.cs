using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{ 
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 30 * Time.deltaTime);
    }
}