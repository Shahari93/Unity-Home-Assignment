using UnityEngine;
using DG.Tweening;

public class CircleHandler : MonoBehaviour
{
    private SpriteRenderer _circleSpriteRend;
    [SerializeField] float _startPosY, _endPosY, _moveDuration;
    [SerializeField] int _loops;

    private void Awake()
    {
        _circleSpriteRend = GetComponent<SpriteRenderer>();
    }

    public void OnButtonClick()
    {
        _circleSpriteRend.material.color = Random.ColorHSV(0f, 1f, 0.1f, 1f, 0.1f, 1f);
        transform.DOMoveY(_endPosY, _moveDuration)
            .ChangeStartValue(new Vector2(transform.position.x, _startPosY))
            .SetLoops(_loops, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
}