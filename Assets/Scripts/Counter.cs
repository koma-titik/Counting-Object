using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private TextMeshProUGUI _score;

    [Header("Score Value")]
    private int _scoreValue;

    [Header("Item Count")]
    [SerializeField] private int _countApple;
    [SerializeField] private int _countPear;
    [SerializeField] private int _countSandwich;

    [Header("Item Values")]
    [SerializeField] private int _appleValue;
    [SerializeField] private int _pearValue;
    [SerializeField] private int _sandwichValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            _countApple++;
        }

        else if (other.CompareTag("Pear"))
        {
            _countPear++;
        }

        else if (other.CompareTag("Sandwich"))
        {
            _countSandwich++;
        }

        int totalItems = (_countApple * _appleValue) + (_pearValue * _countPear) + (_sandwichValue * _countSandwich);

        _counterText.SetText($"Apples: {_countApple} Pears: {_countPear} Sandwiches: {_countSandwich}");
        _score.SetText($"Score: {totalItems}");
    }
}
