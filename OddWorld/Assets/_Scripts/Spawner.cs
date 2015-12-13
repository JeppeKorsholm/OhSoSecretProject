using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
  
    public GameObject caravanPrefab;
    public GameObject connectedCity;
    

    private Vector3 _cityDirection;
    private Quaternion _spawnDirection;

	// Use this for initialization
	void Start ()
	{


        

        //sets spawn distance towards target city
        _cityDirection = 5 * Vector3.Normalize(connectedCity.transform.position - transform.position);

        //sets rotation of spawned objects
        _spawnDirection = Quaternion.LookRotation(transform.position - connectedCity.transform.position);
        Debug.Log(_spawnDirection.eulerAngles);
        _spawnDirection = Quaternion.Euler(0, _spawnDirection.eulerAngles.y, 0);
        Debug.Log(_spawnDirection.eulerAngles);
        

    }
	
	// Update is called once per frame
	void Update () {
     

	    if (Input.GetKeyDown(KeyCode.S))
	    {
	        Instantiate(caravanPrefab, transform.position + _cityDirection, _spawnDirection);
            
	    }
       //Vector3.MoveTowards()
	}

    
}
