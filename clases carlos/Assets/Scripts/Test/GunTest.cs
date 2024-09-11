using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTest : MonoBehaviour
{
    public Transform shootingPoint;
    public float startDistance;
    
    LineRenderer lineRenderer;

    float currentDistance;    

    //public GameObject shootingPoint;
    Vector3 origin;
    Vector3 direction;



    void Start()
    {
       
        //direction = new Vector3(0, 0, 1);
        direction = Vector3.forward;
        lineRenderer = GetComponent<LineRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        origin = shootingPoint.position;

        Ray ray = new Ray(origin, direction);

        if(Physics.Raycast(ray, out RaycastHit hit, currentDistance))
	    {            
		   Debug.Log("choque con: " + hit.collider.name);
           currentDistance = Vector3.Distance(origin, hit.point);
           //hit.collider.GetComponent<EnemyTest>().Deactivate();
           hit.collider.GetComponent<EnemyTest>().TakeDamage(3);
	    }
        else
        {
            currentDistance = startDistance;
        }

        Debug.DrawRay(origin, direction * currentDistance, Color.green);
        lineRenderer.SetPosition(0, origin);
        lineRenderer.SetPosition(1, origin + (direction * currentDistance));

    }
}
