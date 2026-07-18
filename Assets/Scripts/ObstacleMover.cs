using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back*speed*Time.deltaTime);
        if(transform.position.z < -10)
        {
            transform.position = new Vector3(
                Random.Range(-2f,2f),
                transform.position.y,
                20f 
                 );
        }
    }
}
