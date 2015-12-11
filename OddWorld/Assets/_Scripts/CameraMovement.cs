using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{


    public Transform Player;
    public float Speed;
    public float OffSetY;
    public float OffSetZ;

	// Use this for initialization
	void Start ()
	{

	    Speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {


    
      transform.position = Vector3.Lerp(transform.position, new Vector3(Player.position.x, Player.position.y+OffSetY, Player.position.z-OffSetZ ), Time.deltaTime*Speed);

    }
}
