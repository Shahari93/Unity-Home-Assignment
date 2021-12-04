using UnityEngine;
using System.Collections;

public class CircleHandler : MonoBehaviour
{
    private SpriteRenderer _circleSpriteRenderer;
    private Animator _circleAnim;

    private WaitForSecondsRealtime _waitForTriggerReset;
    [SerializeField] float _waitForTriggerResetTime;


    private void Awake()
    {
        _circleSpriteRenderer = GetComponent<SpriteRenderer>();
        _circleAnim = GetComponent<Animator>();
        _waitForTriggerReset = new WaitForSecondsRealtime(_waitForTriggerResetTime);
    }

    public void OnButtonClick()
    {
        StartCoroutine(ControlCircle());
    }

    private void ChangeToRandomColor()
    {
        _circleSpriteRenderer.material.color = Random.ColorHSV(0f, 1f, 0.1f, 1f, 0.1f, 1f);
    }

    private void MoveCircle()
    {
        _circleAnim.SetTrigger("IsMove");
    }

    IEnumerator ControlCircle()
    {
        ChangeToRandomColor();
        MoveCircle();
        yield return _waitForTriggerReset;
        _circleAnim.ResetTrigger("IsMove");
    }
}