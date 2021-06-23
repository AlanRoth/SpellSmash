using System.Collections.Generic;
using UnityEngine;

public class NextLetter : MonoBehaviour
{

    public static char GetNextLetter(List<Letter> alphabet)
    {
        int totalWeight = 0;
        char val = new char();

        foreach (var letter in alphabet)
        {
            totalWeight += letter.Value;
        }

        int randomNumber = Random.Range(0, totalWeight);

        foreach (var letter in alphabet)
        {
            if (randomNumber < letter.Weight)
            {
                val = letter.Value;
            }
            else
            {
                val = '\0';
            }
            randomNumber -= letter.Value;
        }

        return val;
    }

}
