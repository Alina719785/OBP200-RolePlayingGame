namespace OBP200_RolePlayingGame;

public class Enemy
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int ATK { get; set; }
    public int DEF { get; set; }
    public int XPReward { get; set; }
    public int GoldReward { get; set; }
    
    public Enemy(string name, int hp, int atk, int def, int xp, int gold)
    {
        Name = name;
        HP = hp;
        ATK = atk;
        DEF = def;
        XPReward = xp;
        GoldReward = gold;
    }

    public virtual int Attack()
    {
        return ATK;
    }
}

public class Boss : Enemy
{
    public Boss(string name, int hp, int atk, int def, int xp, int gold)
        : base(name, hp, atk, def, xp, gold)
    {
    }

    public override int Attack()
    {
        return ATK + 3;
    }
}

