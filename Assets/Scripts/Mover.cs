using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField, Min(0)] private float _deltaTime;

    [SerializeField] private Vector3 _deltaPosition;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        //Gizmos.DrawRay(transform.position, );
    }

    private void Start() =>
        transform.DOMove(_deltaPosition, _deltaTime).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
}
