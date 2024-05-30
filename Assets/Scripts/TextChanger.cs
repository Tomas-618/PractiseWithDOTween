using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField, Min(0)] private float _duration;

    [SerializeField] private string[] _desired;

    private Text _view;

    private void Awake() =>
        _view = GetComponent<Text>();

    private void Start()
    {
        DOTween.Sequence()
            .Append(_view.DOText(_desired[0], _duration))
            .Append(_view.DOText(_desired[1], _duration).SetRelative())
            .Append(_view.DOText(_desired[2], _duration, scrambleMode: ScrambleMode.All));
    }
}
