using UnityEngine;
using System.Collections;

public class CaravanMover : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
   

	// Use this for initialization
	void Start ()
	{
	    speed = 5f;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        rb.AddRelativeForce( gameObject.transform.TransformDirection(Vector3.forward) * speed);

    }
}
