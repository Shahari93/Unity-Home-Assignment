using UnityEngine;
using System.Collections;

public class CircleHandler : MonoBehaviour
{
    private SpriteRenderer _circleSpriteRenderer;
    private Animator _circleAnim;


    private void Awake()
    {
        _circleSpriteRenderer = GetComponent<SpriteRenderer>();
        _circleAnim = GetComponent<Animator>();
    }

    public void OnButtonClick()
    {
        StartCoroutine(ControlCircle());
        //ChangeToRandomColor();
        //MoveCircle();
    }

    private void ChangeToRandomColor()
    {
        _circleSpriteRenderer.material.color = Random.ColorHSV(0f, 1f, 0.1f, 1f, 0.1f, 1f);
    }

    private void MoveCircle()
    {
        _circleAnim.SetTrigger("IsMove");
        //transform.DOLocalPath(pathWaypoints, _moveDuration, PathType.Linear, PathMode.TopDown2D);
        //transform.DOLocalMoveY(_endPosY, _moveDuration)
        //   .SetLoops(_loops, LoopType.Yoyo)
        //   .ChangeStartValue(new Vector2(transform.position.x, _startPosY))
        //   .SetEase(Ease.InOutSine);
    }

    IEnumerator ControlCircle()
    {
        ChangeToRandomColor();
        MoveCircle();
        yield return new WaitForSecondsRealtime(0.3f);
        _circleAnim.ResetTrigger("IsMove");
    }
}