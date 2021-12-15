using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockView : MonoBehaviour
{
    [SerializeField] private TMP_Text _view;

    private Block _block;

    private void Awake()
    {
        _block = GetComponent<Block>();
    }

    private void OnEnable()
    {
        _block.EatingUpdated += OnEatingUpdated;
    }

    private void OnDisable()
    {
        _block.EatingUpdated -= OnEatingUpdated;
    }

    private void OnEatingUpdated(int leftToEat)
    {
        _view.text = leftToEat.ToString();
    }
}
