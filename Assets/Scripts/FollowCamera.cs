using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // object reference
    [SerializeField] GameObject carToFollow;
    
    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
