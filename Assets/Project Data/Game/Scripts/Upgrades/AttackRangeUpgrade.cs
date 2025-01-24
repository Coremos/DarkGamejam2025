using UnityEngine;

namespace Watermelon
{
    using GlobalUpgrades;
    using System.Linq;

    [CreateAssetMenu(fileName = "AttackRange Upgrade", menuName = "Content/Upgrades/AttackRange Upgrade")]
    public class AttackRangeUpgrade : GlobalUpgrade<AttackRangeUpgrade.AttackRangeUpgradeStage>
    {
        public override void Initialise()
        {
            upgrades = ReferenceTable.Upgrade.GetList()
                .Where(s => s.abilityType1 == "AttackRange")
                .Select(s => AttackRangeUpgradeStage.Create(s.goldCost, CurrencyType.Coins, null, s.abilityAmount1)).ToArray();
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
        public class AttackRangeUpgradeStage : GlobalUpgradeStage
        {
            public static AttackRangeUpgradeStage Create(int price, CurrencyType currencyType, Sprite previewSprite, float value)
            {
                var stage = new AttackRangeUpgradeStage
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

