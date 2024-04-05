using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float deathAltitude = 10f;

    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }
        if (target.position.y < transform.position.y - deathAltitude)
        {
            GameOver();
        }
        
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
