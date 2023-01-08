using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bullet, shotEffect;
    public Transform shootPoint, shootEffectPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            Instantiate(shotEffect, shootEffectPoint.position, shootEffectPoint.rotation);
        }
    }
}
