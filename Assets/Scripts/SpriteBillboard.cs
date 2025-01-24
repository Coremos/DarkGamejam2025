using UnityEngine;

namespace Watermelon
{
    public class SpriteBillboard : MonoBehaviour
    {
        private Transform _cameraTransform;

        private void Awake()
        {
            _cameraTransform = Camera.main.transform;
        }

        private void Update()
        {
            transform.rotation = Quaternion.Euler(0f, _cameraTransform.rotation.eulerAngles.y, 0f);
        }
    }
}