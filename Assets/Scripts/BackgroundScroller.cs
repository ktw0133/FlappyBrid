using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Image _image;
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
