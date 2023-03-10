using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRotate : MonoBehaviour
{
    public float offset;
    public Transform crosshair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = crosshair.position - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);
    }
}
