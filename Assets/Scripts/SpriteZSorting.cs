using UnityEngine;

namespace Watermelon.Assets.Scripts
{
    public class SpriteZSorting : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        private void FixedUpdate()
        {
            if (_spriteRenderer == null) return;
            _spriteRenderer.sortingOrder = -(int)(transform.position.z * 10f);
        }
    }
}
