using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public Transform StartMarker;
    public Transform EndMarker;
    public float speed = 1.0F;
    public float maxSpeed = 10;
    public float startTime;
    public float journeyLength;
    public bool Moving = false;

    private Rigidbody rb;

    private Quaternion _targetRotation;


    void OnTriggerEnter(Collider other)
    {
        Moving = false;
    }


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {

       
        if (Input.GetMouseButtonDown(0))
        {
            startTime = Time.time;
            journeyLength = Vector3.Distance(StartMarker.position, EndMarker.position);
         
            Moving = true;
        }



        if (Moving)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;



            _targetRotation = Quaternion.LookRotation(EndMarker.position - StartMarker.position);
            Debug.Log(Vector3.Distance(transform.position, EndMarker.position));
            if (Vector3.Distance(transform.position, EndMarker.position) > 0.1f && rb.velocity.magnitude < maxSpeed)
            {
                rb.AddForce(transform.forward*speed,ForceMode.Acceleration);
            }
            //transform.position = Vector3.Lerp(StartMarker.position, EndMarker.position, fracJourney);

            transform.rotation = Quaternion.Slerp(StartMarker.rotation, _targetRotation, (Time.time - startTime) * 0.1f);

         //  

            //  transform.Rotate(Vector3.left * Time.deltaTime);
        }




   

    }




}

