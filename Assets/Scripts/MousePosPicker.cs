using UnityEngine;
using System.Collections;

public class MousePosPicker : MonoBehaviour
{
    Plane plane;
    float counter;

    public float rotAngle;
    public GameObject projectile;
    
	// Use this for initialization
	void Start ()
    {
        plane = new Plane(Vector3.up, Vector3.zero);
        counter = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.eulerAngles = new Vector3(270, transform.eulerAngles.y + rotAngle, 0);
        counter += Time.deltaTime;
        counter %= Mathf.PI * 2f;
        float scale = 5f + Mathf.Sin(counter * 10);
        transform.localScale = new Vector3(scale, scale, scale);

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);

        var point = ray.GetPoint(dist);
        point.y = 0.1f;
        transform.position = point;

        if (Input.GetMouseButtonDown(0))
        {
            var obj = (GameObject)Instantiate(projectile, new Vector3(point.x, 10, point.z), Quaternion.identity);
            obj.GetComponent<BasicProjectile>().target = new Vector3(point.x, 0, point.z);
            obj.GetComponent<BasicProjectile>().speed = 0.1f;
        }
	}
}