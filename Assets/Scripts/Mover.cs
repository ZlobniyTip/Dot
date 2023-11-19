using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _leadTime;

    private Vector3 _meaningMovement = new Vector3(10, 0, 0);

    private void Start()
    {
        transform.DOMove(_meaningMovement, _leadTime);
    }
}
