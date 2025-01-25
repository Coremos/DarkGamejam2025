using UnityEngine;

namespace Watermelon
{
    using GlobalUpgrades;
    using System.Linq;
    using static Watermelon.AttackRangeUpgrade;

    [CreateAssetMenu(fileName = "AttackSpeed Upgrade", menuName = "Content/Upgrades/AttackSpeed Upgrade")]
    public class AttackSpeedUpgrade : GlobalUpgrade<AttackSpeedUpgrade.AttackSpeedUpgradeStage>
    {
        public override void Initialise()
        {
            upgrades = ReferenceTable.Upgrade.GetList()
                .Where(s => s.AbilityType1 == "AttackSpeed")
                .Select(s => AttackSpeedUpgradeStage.Create(s.GoldCost, CurrencyType.Coins, null, s.AbilityAmount1)).ToArray();
        }

        public override string GetUpgradeDescription(int stageId)
        {
            try
            {
                var prevValue = GetStage(stageId).Value;
                var value = GetStage(stageId + 1).Value;

                return string.Format(DescriptionFormat, prevValue, value);
            }
            catch
            {
                return "";
            }
        }

        [System.Serializable]
        public class AttackSpeedUpgradeStage : GlobalUpgradeStage
        {
            public static AttackSpeedUpgradeStage Create(int price, CurrencyType currencyType, Sprite previewSprite, float value)
            {
                var stage = new AttackSpeedUpgradeStage
                {
                    price = price,
                    currencyType = currencyType,
                    previewSprite = previewSprite,
                    value = value
                };

                return stage;
            }

            [SerializeField] float value;
            public float Value => value;
        }
    }
}

