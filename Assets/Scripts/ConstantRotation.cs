using UnityEngine;
using System.Collections;

public class ConstantRotation : MonoBehaviour
{
    public Vector3 rotation;

	// Update is called once per frame
	void Update ()
    {
        transform.rotation = Quaternion.Euler(rotation);
	}
}