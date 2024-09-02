using DG.Tweening;
using UnityEngine;

public class Scaler : LoopTween
{
    [SerializeField] private Vector3 _targetSize;

    private void Start()
    {
        transform.DOScale(_targetSize, Duration).SetLoops(CountLoop, LoopType);
    }
}
