using UnityEngine;

namespace Watermelon.Assets.Scripts
{
    public class SpriteZSorting : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private int _sortingOffset;

        private void FixedUpdate()
        {
            if (_spriteRenderer == null) return;
            _spriteRenderer.sortingOrder = _sortingOffset - (int)(transform.position.z * 10f);
        }
    }
}