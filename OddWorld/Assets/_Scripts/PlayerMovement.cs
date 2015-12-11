using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public Transform StartMarker;
    public Transform EndMarker;
    public float speed = 1.0F;
    public float startTime;
    public float journeyLength;
    public bool Moving = false;

    private Quaternion _targetRotation;


    void OnTriggerEnter(Collider other)
    {
        Moving = false;
    }


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    private void Update()
    {

       
        if (Input.GetMouseButtonDown(0))
        {
            startTime = Time.time;
            journeyLength = Vector3.Distance(StartMarker.position, EndMarker.position);
            /*
                GameObject markerObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                markerObject.AddComponent<Rigidbody>();
                markerObject.transform.position = hit.point;
                */
            Moving = true;
        }



        if (Moving)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;



            _targetRotation = Quaternion.LookRotation(StartMarker.position-EndMarker.position );


            transform.position = Vector3.Lerp(StartMarker.position, EndMarker.position, fracJourney);

            transform.rotation = Quaternion.Slerp(StartMarker.rotation, _targetRotation, (Time.time - startTime) * 0.1f);

         //  

            //  transform.Rotate(Vector3.left * Time.deltaTime);
        }




   

    }




}

