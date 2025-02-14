using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(0, -1, 0);
        transform.RotateAround(Vector3.zero, axis, 60 * Time.deltaTime);
    }
}
