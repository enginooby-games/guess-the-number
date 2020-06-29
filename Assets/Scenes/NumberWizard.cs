using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }

    public void onPressHiger()
    {
        min = guess;
        NextGuess();
    }
    public void onPressLower()
    {
        max = guess;
        NextGuess();
    }

}
