using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField, Min(0)] private float _duration;

    [SerializeField] private Color _desired;

    private Material _material;

    private void Awake() =>
        _material = GetComponent<MeshRenderer>().material;

    private void Start()
    {
        _material.DOColor(_desired, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
