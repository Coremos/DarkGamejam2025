using UnityEngine;

namespace Watermelon
{
    public class SpriteBillboard : MonoBehaviour
    {
        private Transform _cameraTransform;
        private float _scaleY;

        private void Awake()
        {
            _cameraTransform = Camera.main.transform;
            _scaleY = transform.localScale.y;
        }

        private void Update()
        {
            float a = Mathf.Cos(_cameraTransform.rotation.eulerAngles.x * Mathf.Deg2Rad);
            transform.localScale = new Vector2(transform.localScale.x, _scaleY / a);
            transform.rotation = Quaternion.Euler(0f, _cameraTransform.rotation.eulerAngles.y, 0f);
        }
    }
}