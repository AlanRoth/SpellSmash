using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PreviewScript : MonoBehaviour
{
    public List<TextMeshProUGUI> previewTexts;

    private void Start()
    {
        RefreshText();
    }

    public void RefreshText()
    {
        var letterQueue = Alphabet.GetLetterQueue();
        for (int x = 0; x < previewTexts.Count && x < letterQueue.Count; x++)
        {
            if (previewTexts[x] != null)
            {
                previewTexts[x].text = letterQueue[x].ToString();
            }
        }
    }


}
