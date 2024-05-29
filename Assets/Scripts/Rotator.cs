using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField, Min(0)] private float _duration;

    private void Start()
    {
        const int HalfMaxAngle = 180;

        transform.DORotate(Vector3.up * HalfMaxAngle, _duration).SetEase(Ease.Linear).SetLoops(-1);
    }
}
