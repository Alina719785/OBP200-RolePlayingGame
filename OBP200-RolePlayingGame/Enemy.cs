namespace OBP200_RolePlayingGame;

public class Enemy
{
    public string Name { get; protected set; }
    public int HP { get; protected set; }
    public int ATK { get; protected set; }
    public int DEF { get; protected set; }
    public int XPReward { get; protected set; }
    public int GoldReward { get; protected set; }
    
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

