using UnityEngine;

public class nextLevelScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)

    {
        Debug.Log("here");
        if (collision.CompareTag("Player"))
        {
            gameManager.instance.loadLevel();
        }
    }
}
