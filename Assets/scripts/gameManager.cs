
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

    
    public   playerScript player;
    public   uiManager uiManager;
    public wordManager wordManager;

    public inputManager inputManager;

    private string currentWord;



    private void Start()
    {
        
        currentWord = wordManager.GenerateWord();

        uiManager.UpdateWordText(currentWord);
    }

    private void Update()
    {
        
        inputManager.readWord();
        inputManager.deleteWord();
        uiManager.UpdateTypedText(inputManager.playerInput);
        verifyCurrentWord();
    }
    public void loadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




    
    private void verifyCurrentWord()
    {
         if(inputManager.playerInput == wordManager.GetCurrentWord())
        {
            player.playerMovement();
            inputManager.resetInput();
            
            currentWord = wordManager.GenerateWord();;
            uiManager.UpdateWordText(currentWord);
        }
    }

    
}
