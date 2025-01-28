using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingGun : MonoBehaviour
{
    private LineRenderer lr;
    private Vector2 grapplePoint;
    public LayerMask whatIsGrappleable;
    public Transform gunTip;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonDown(0)) 
        {
            StopGrapple();
        }
    }

    public void StartGrapple() 
    {
        //if(Physics2D.Raycast)
    }

    public void StopGrapple() 
    {

    }
}
