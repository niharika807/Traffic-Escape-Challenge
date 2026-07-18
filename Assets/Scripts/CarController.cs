using UnityEngine;

public class CarControllers : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 8f;

    void Update()
    {
        // Move the car forward automatically
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Move left and right
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * turnSpeed * Time.deltaTime);
    }
}