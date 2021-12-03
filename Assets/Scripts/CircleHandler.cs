using UnityEngine;
using DG.Tweening;

public class CircleHandler : MonoBehaviour
{
    private SpriteRenderer _circleSpriteRenderer;
    [SerializeField] float _startPosY, _endPosY, _moveDuration;
    [SerializeField] int _loops;

    private void Awake()
    {
        _circleSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnButtonClick()
    {
        ChangeToRandomColor();
        MoveCircle();
    }

    private void ChangeToRandomColor()
    {
        _circleSpriteRenderer.material.color = Random.ColorHSV(0f, 1f, 0.1f, 1f, 0.1f, 1f);
    }

    private void MoveCircle()
    {
        transform.DOLocalMoveY(_endPosY, _moveDuration)
            .SetLoops(_loops, LoopType.Yoyo)
            .ChangeStartValue(new Vector2(transform.position.x, _startPosY))
            .SetEase(Ease.InOutSine);
    }
}