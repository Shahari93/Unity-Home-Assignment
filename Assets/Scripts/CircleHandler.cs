using UnityEngine;
using DG.Tweening;

public class CircleHandler : MonoBehaviour
{
    private SpriteRenderer _circleSpriteRend;

    private void Awake()
    {
        _circleSpriteRend = GetComponent<SpriteRenderer>();
    }

    public void OnButtonClick()
    {
        _circleSpriteRend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        transform.DOMove(new Vector3(transform.position.x,-3,transform.position.z), 0.5f);
    }
}