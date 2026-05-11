
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class typingScript : MonoBehaviour
{
    public TMP_Text wordText;
    public TMP_Text typedText;

    public playerScript player;

    private string currentWord;

    private string playerInput = "";

    private string[] words =
    {   
        "castle",
        "sword",
        "dragon",
        "pixel",
        "unity"
    };




    private void Start()
    {
        GenerateWord();
    }

    private void Update()
    {
        readWord();
        deleteWord();
        verifyCurrentWord();
    }

    private void MovePlayer()
    {
        player.playerMovement();
        StartCoroutine(player.StopMovement());
    }

    private void verifyCurrentWord()
    {
         if(playerInput == currentWord)
        {
            MovePlayer();

            playerInput = "";

            typedText.text = "";
            GenerateWord();
            
        }
    }

    void GenerateWord()
    {
        currentWord = words[Random.Range(0, words.Length)];
        wordText.text = currentWord;

    }

    private void deleteWord()
    {
         if(Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            if(playerInput.Length > 0)
            {
                playerInput =
                    playerInput.Substring(0, playerInput.Length - 1);

                typedText.text = playerInput;
            }
        }

    }

    private void readWord()
    {
        foreach(KeyControl key in Keyboard.current.allKeys)
        {
            if(key.wasPressedThisFrame)
            {
                string keyName = key.displayName.ToLower();

                if(keyName.Length == 1)
                {
                    playerInput += keyName;

                    typedText.text = playerInput;
                    
                }
            }
        }
    }
}
