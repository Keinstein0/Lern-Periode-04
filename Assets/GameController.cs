using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(1, 0, 0);
        transform.RotateAround(Vector3.zero, axis, 10 * Time.deltaTime);
    }

    void AddBall()
    {

    }
}
