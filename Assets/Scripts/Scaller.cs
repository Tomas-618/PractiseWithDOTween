using UnityEngine;
using DG.Tweening;

public class Scaller : MonoBehaviour
{
    [SerializeField, Min(0)] private float _duration;

    [SerializeField] private float _desiredScale;

    private void Start() =>
        transform.DOScale(_desiredScale, _duration);
}
