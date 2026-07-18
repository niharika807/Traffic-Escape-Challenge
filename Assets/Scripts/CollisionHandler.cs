using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject gameOverCanvas;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}