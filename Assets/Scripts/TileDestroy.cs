using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.z + 10.0f < Camera.main.transform.position.z)
            Destroy(gameObject);
    }
}
