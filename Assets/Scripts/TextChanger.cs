using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : LoopTween
{
    [SerializeField] private string _replacementText;
    [SerializeField] private string _addendumText;
    [SerializeField] private string _overkillSubstitutionText;
        
    private void Start()
    {
        Text text = GetComponent<Text>();
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(text.DOText(_replacementText, Duration));
        sequence.Append(text.DOText(_addendumText, Duration).SetRelative());
        sequence.Append(text.DOText(_overkillSubstitutionText, Duration, true, ScrambleMode.All));
        sequence.SetLoops(CountLoop, LoopType);
    }
}
