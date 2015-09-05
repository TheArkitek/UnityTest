using UnityEngine;
using System.Collections;

public class BasicProjectile : MonoBehaviour
{
    public Vector3 target;
    public float speed = 0.05f;

    void Start ()
    {

    }

	void Update ()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target, speed);
    }
}