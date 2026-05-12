using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class inputManager : MonoBehaviour
{
   public playerScript player;
   public string playerInput = "";
   
   public void readWord()
    {
        foreach(KeyControl key in Keyboard.current.allKeys)
        {
            if(key.wasPressedThisFrame)
            {
                string keyName = key.displayName.ToLower();

                if(keyName.Length == 1)
                {
                    playerInput += keyName;
                    
                }
            }
        }
    }


    


    public void deleteWord()
    {
         if(Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            if(playerInput.Length > 0)
            {
                playerInput =
                    playerInput.Substring(0, playerInput.Length - 1);

            }
        }

    }

    public void resetInput()
    {
        playerInput = "";
    }
}
