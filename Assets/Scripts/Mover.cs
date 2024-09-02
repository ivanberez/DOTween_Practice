using UnityEngine;
using DG.Tweening;

public class Mover : LoopTween
{
    [SerializeField] private Vector3 _position;
    
    private void Start()
    {
        transform.DOMove(_position, Duration).SetLoops(CountLoop, LoopType);
    }
}
