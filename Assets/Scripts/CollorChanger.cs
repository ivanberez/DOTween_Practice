using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class CollorChanger : LoopTween
{
    [SerializeField] private Color32 _targetColor;

    private void Start()
    {
        var rendere = GetComponent<Renderer>();

        rendere.material.DOColor(_targetColor, Duration).SetLoops(CountLoop, LoopType);        
    }
}
