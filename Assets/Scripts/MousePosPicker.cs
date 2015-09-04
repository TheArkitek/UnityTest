using UnityEngine;
using System.Collections;

public class MousePosPicker : MonoBehaviour
{
    Plane plane;

	// Use this for initialization
	void Start ()
    {
        plane = new Plane(Vector3.up, Vector3.zero);
	}
	
	// Update is called once per frame
	void Update ()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);

        var point = ray.GetPoint(dist);
        point.y = 0.1f;
        transform.position = point;
	}
}
