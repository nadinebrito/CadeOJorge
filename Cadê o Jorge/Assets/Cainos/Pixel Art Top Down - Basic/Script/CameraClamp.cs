using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    
    // Start is called before the first frame update
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, -38.12f, 4.15f),
            Mathf.Clamp(targetToFollow.position.y, -11.04f, 2.08f),
            transform.position.z);
    }
}
