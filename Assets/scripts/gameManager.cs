using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
   #region  Singleton
        private static gameManager _instance;

        public static gameManager instance => _instance;

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            _instance = this;
        }

    }
    #endregion


        public string[] words =
    {
        "asdf",
        "jklç"
    };

    public void loadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
