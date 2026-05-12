
using UnityEngine;

public class wordManager : MonoBehaviour
{

    private string currentWord;

     private string[] words = {
    "w",
    "a",
    "s",
    "d",
    "q",
    "e",
    "r",
    "t",
    "y",
    "u",
    "i",
    "o",
    "p",
    "z",
    "x",
    "c",
    "v",
    "b",
    "n",
    "m"};

     public string GenerateWord()
    {
        currentWord = words[
            Random.Range(0, words.Length)];
        Debug.Log("Current Word: " + currentWord);
        return currentWord;
    }


     public string GetCurrentWord()
    {
        return currentWord;
    }

   
}
