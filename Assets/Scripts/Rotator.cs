using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _turnaroundTime;

    private Vector3 _rotationValue = new Vector3(360, 0, 0);

    private void Start()
    {
        transform.DORotate(_rotationValue, _turnaroundTime, RotateMode.FastBeyond360);
    }
}
