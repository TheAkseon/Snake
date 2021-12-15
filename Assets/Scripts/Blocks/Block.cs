using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] private Vector2Int _destroyPriceRange;

    private int _destroyPrice;
    private int _eating;
    public int LeftToEat => _destroyPrice - _eating;

    public event UnityAction<int> EatingUpdated;

    private void Start()
    {
        _destroyPrice = Random.Range(_destroyPriceRange.x, _destroyPriceRange.y);

        EatingUpdated?.Invoke(LeftToEat);
    }

    public void Eat()
    {
        _eating++;
        EatingUpdated?.Invoke(LeftToEat);

        if (_eating == _destroyPrice)
        {
            Destroy(gameObject);
        }
    }
}
