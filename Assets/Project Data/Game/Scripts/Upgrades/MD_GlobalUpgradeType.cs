namespace Watermelon
{
    public enum GlobalUpgradeType
    {
        None = -1,

        MovementSpeed = 0, // 이동속도 ( 사용 )
        Capacity = 1, // 용량 ( 사용 )
        Gathering = 2, // 수집량 - 공격력 ( 사용 )
        SwimmingDuration = 3, // 사용하지 않음

        AttackSpeed = 12, // 공격속도 ( 사용 )
        AttackRange = 13, // 공격범위 ( 사용 )
    }
}