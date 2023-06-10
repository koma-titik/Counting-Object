using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    public TextMeshProUGUI score;

    private int scoreValue;
    private int countApple = 0;
    private int countPear = 0;
    private int countSandwich = 0;
    private int appleValue = 10;
    private int pearValue = 15;
    private int sandwichValue = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            countApple++;
        }
        else if (other.CompareTag("Pear"))
        {
            countPear++;
        }
        else if (other.CompareTag("Sandwich"))
        {
            countSandwich++;

        }
        int totalItems = (countApple * appleValue) + (pearValue * countPear) + (sandwichValue * countSandwich);

        CounterText.SetText($"Apples: {countApple} Pears: {countPear} Sandwiches: {countSandwich}");
        score.SetText($"Score: {totalItems}");
    }
}
