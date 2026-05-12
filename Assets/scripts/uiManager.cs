using TMPro;
using UnityEngine;

public class uiManager : MonoBehaviour
{
     [SerializeField] private TMP_Text wordText;
    [SerializeField] private TMP_Text typedText;

     public void UpdateWordText(string word)
    {
        wordText.text = word;
    }
    public void UpdateTypedText(string text)
    {
        typedText.text = text;
    }


}
