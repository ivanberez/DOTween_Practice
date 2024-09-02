using DG.Tweening;
using UnityEngine;

public abstract class LoopTween : MonoBehaviour
{    
    [SerializeField] protected float Duration = 1;
    [SerializeField] protected LoopType LoopType = LoopType.Yoyo;
    [SerializeField, Min(-1)] protected int CountLoop = -1;
}
