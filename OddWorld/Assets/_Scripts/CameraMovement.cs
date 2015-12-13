using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{


    public GameObject Player;
    public float Speed;
    public float OffSetY;
    public float OffSetZ;

	// Use this for initialization
	void Start ()
	{
        Player = GameObject.FindGameObjectWithTag("Player");

	    Speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {


	    if (Player != null)
	    {
	        transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y+OffSetY, Player.transform.position.z-OffSetZ ), Time.deltaTime*Speed);
	    }

    }
}
