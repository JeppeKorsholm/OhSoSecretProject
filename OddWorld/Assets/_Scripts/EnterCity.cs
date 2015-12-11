using UnityEngine;
using System.Collections;



public class EnterCity : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("tag");

        if (other.tag == "Player")
        {
            Destroy(other.gameObject);

            

            //gameManager.worldMovement = false
            //bring up CityGUI

        }
    }


}
