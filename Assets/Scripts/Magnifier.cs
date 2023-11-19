using UnityEngine;
using DG.Tweening;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _rateChange;

    private Vector3 _growthLimit = new Vector3(3, 3, 3);

    private void Start()
    {
        transform.DOScale(_growthLimit, _rateChange);
    }
}
