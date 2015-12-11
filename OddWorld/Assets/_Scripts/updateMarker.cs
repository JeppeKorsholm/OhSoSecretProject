using UnityEngine;
using System.Collections;

public class updateMarker : MonoBehaviour
{

    public Transform Player;

    private Vector3 _targetTransform;

    private float _angle;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                _targetTransform = new Vector3(hit.point.x, hit.point.y + Player.position.y, hit.point.z);

                transform.position = _targetTransform;

            }
        }


    }

}



