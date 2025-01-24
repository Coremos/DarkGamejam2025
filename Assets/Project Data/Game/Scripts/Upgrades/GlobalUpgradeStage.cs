using UnityEngine;

namespace Watermelon.GlobalUpgrades
{
    [System.Serializable]
    public abstract class GlobalUpgradeStage
    {
        [SerializeField] protected int price;
        public int Price => price;

        [SerializeField] protected CurrencyType currencyType;
        public CurrencyType CurrencyType => currencyType;

        [SerializeField] protected Sprite previewSprite;
        public Sprite PreviewSprite => previewSprite;
    }
}