using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _leadTime;

    private void Start()
    {
        transform.DOMove(new Vector3(10,0,0), _leadTime);
    }
}
