using UnityEngine;
using System.Collections;

public class EntitySpawner : MonoBehaviour
{
    private int spawnCounter;

    public int spawnDelay;
    public GameObject entity;

    // Use this for initialization
    void Start ()
    {
        spawnCounter = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (entity == null)
            return;
	    if (++spawnCounter >= spawnDelay)
        {
            spawnCounter = 0;
            Vector3 pos = transform.position + new Vector3(
                transform.localScale.x * Random.value,
                transform.localScale.y * Random.value,
                transform.localScale.z * Random.value
                ) - transform.localScale * 0.5f;

            var instance = (GameObject)Instantiate(entity, pos, Quaternion.identity);
            //float scale = 5f + Random.value * 4f;
            //instance.transform.localScale = new Vector3(scale, scale, scale);
            instance.transform.Rotate(0, 180, 0);
        }
	}
}