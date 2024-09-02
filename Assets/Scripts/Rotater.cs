using DG.Tweening;
using UnityEngine;

public class Rotater : LoopTween
{
    [SerializeField] private Vector3 _targetAngle;

    private void Start()
    {
        transform.DORotate(_targetAngle, Duration).SetLoops(CountLoop, LoopType);
    }
}
