using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _turnaroundTime;

    private void Start()
    {
        transform.DORotate(new Vector3(360, 0, 0), _turnaroundTime, RotateMode.FastBeyond360);
    }
}
