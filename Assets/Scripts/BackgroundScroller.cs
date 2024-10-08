using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 배경 스크롤 해주는 컴포넌트
public class BackgroundScroller : MonoBehaviour
{
    // 배경을 움직일 속도
    [SerializeField] private float _speed;

    // 움직일 이미지 컴포넌트
    private Image _image;

    // 오프셋
    private float _offset = 0;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        _offset += _speed * Time.deltaTime;
        _image.material.mainTextureOffset = new Vector2(_offset, 0);
    }
}
