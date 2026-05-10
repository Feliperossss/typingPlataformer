using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class typingScript : MonoBehaviour
{
    public TMP_Text wordText;
    public TMP_Text typedText;

    public Transform player;

    private string currentWord = "castle";

    private string playerInput = "";

    private void Start()
    {
        wordText.text = currentWord;
    }

    private void Update()
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


        if(Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            if(playerInput.Length > 0)
            {
                playerInput =
                    playerInput.Substring(0, playerInput.Length - 1);

                typedText.text = playerInput;
            }
        }

         if(playerInput == currentWord)
        {
            MovePlayer();

            playerInput = "";

            typedText.text = "";
        }

    }

    private void MovePlayer()
    {
         player.position += Vector3.right;
    }
}
