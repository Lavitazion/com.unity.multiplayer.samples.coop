using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class Flotaroceano : MonoBehaviour
{
    /*
    public Rigidbody rb;
    public float depthBefSub;
    public float displacementAmt;
    public int floaters;
    public float waterDrag;
    public float waterAngularDrag;
    public WaterSurface water;
    WaterSearchParameters search;
    WaterSearchResult searchResult;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForceAtPosition(Physics.gravity / floaters, transform.position, ForceMode.Acceleration);

        search.startPosition = transform.position;

        water.FindWaterSurfaceHeight(search, out searchResult);

        if (transform.position.y < searchResult.height)
        {

            float displacementMulti = Mathf.Clamp01(searchResult.height - transform.position.y / depthBefSub) * displacementAmt;
            rb.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMulti, 0f), transform.position, ForceMode.Acceleration);
            rb.AddForce(displacementMulti * -rb.velocity * waterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            rb.AddTorque(displacementMulti * -rb.angularVelocity * waterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
    */
}
