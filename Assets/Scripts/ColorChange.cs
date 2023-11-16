using UnityEngine;
using DG.Tweening;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _rateChange;

    private int _delayDuration = 5;

    private void Start()
    {
        _material.DOColor(_color, _rateChange);
        _material.DOColor(Color.white, _rateChange).SetDelay(_delayDuration);
    }
}
