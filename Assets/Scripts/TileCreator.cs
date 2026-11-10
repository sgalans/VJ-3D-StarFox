using UnityEngine;

public class TileCreator : MonoBehaviour
{
    public GameObject[] tiles;

    float nextZ = 15.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=0; i<10; i++)
        {
            GameObject obj = GameObject.Instantiate(tiles[Random.Range(0, tiles.Length)], transform.position + transform.forward * nextZ, transform.rotation);
            obj.transform.parent = transform;
            nextZ += 10.0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(nextZ - Camera.main.transform.position.z < 100.0f)
        {
            GameObject obj = Instantiate(tiles[Random.Range(0, tiles.Length)], transform.position + transform.forward * nextZ, transform.rotation);
            obj.transform.parent = transform;
            nextZ += 10.0f;
        }
    }
}
