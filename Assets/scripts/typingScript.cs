using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class typingScript : MonoBehaviour
{
    public TMP_Text wordText;
    public TMP_Text typedText;

    public playerScript player;

    private string currentWord = "walk";

    private string playerInput = "";

    private void Start()
    {
        wordText.text = currentWord;
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
        }
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
