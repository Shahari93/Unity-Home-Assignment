using UnityEngine;
using System.Collections;
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

    //public void OnButtonClick()
    //{
    //    ChangeToRandomColor();
    //}

    public void ChangeToRandomColor()
    {
        _circleSpriteRenderer.material.color = Random.ColorHSV(0f, 1f, 0.1f, 1f, 0.1f, 1f);
    }

    public void MoveCircle()
    {
        transform.DOMoveY(_endPosY, _moveDuration)
         .ChangeStartValue(new Vector2(transform.position.x, _startPosY))
         .SetLoops(_loops, LoopType.Yoyo)
         .SetEase(Ease.InOutSine);
    }
}