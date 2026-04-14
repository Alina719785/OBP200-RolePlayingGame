namespace OBP200_RolePlayingGame;

public class Enemy
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int ATK { get; set; }
    public int DEF { get; set; }
    public int XPReward { get; set; }
    public int GoldReward { get; set; }

    public virtual int Attack()
    {
        return ATK;
    }
}

public class Boss : Enemy
{
    public override int Attack()
    {
        return ATK + 3; 
    }
}

