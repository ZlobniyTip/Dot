using UnityEngine;
using DG.Tweening;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _rateChange;

    private void Start()
    {
        transform.DOScale(new Vector3(3, 3, 3), _rateChange);
    }
}
