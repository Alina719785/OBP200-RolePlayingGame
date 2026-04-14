namespace OBP200_RolePlayingGame;

public class Player
{
        public string Name { get; set; }
        public string Class { get; set; }
        public int HP { get; private set; }
        public int MaxHP { get; private set; }
        public int ATK { get; private set; }
        public int DEF { get; private set; }
        public int Gold { get; private set; }
        public int XP { get; private set; }
        public int Level { get; private set; }
        public int Potions { get; private set; }
        public List<string> Inventory { get; private set; }

       
        public bool IsPlayerDead()
        {
            return HP <= 0;
        }

       
        public void ApplyDamageToPlayer(int dmg)
        {
            HP = Math.Max(0, HP - dmg);
        }

       
        public void UsePotion()
        {
            if (Potions <= 0)
            {
                Console.WriteLine("Du har inga drycker kvar.");
                return;
            }

            int heal = 12;
            int newHp = Math.Min(MaxHP, HP + heal);
            HP = newHp;
            Potions--;

            Console.WriteLine($"Du dricker en dryck och återfår {newHp - (HP - heal)} HP.");
        }

       
        public void AddPlayerGold(int amount)
        {
            Gold += Math.Max(0, amount);
        }
      
        public void AddPlayerXp(int amount)
        {
            XP += Math.Max(0, amount);
            MaybeLevelUp();
        }

        
        public void MaybeLevelUp()
        {
            int nextThreshold = Level == 1 ? 10 : (Level == 2 ? 25 : (Level == 3 ? 45 : Level * 20));

            if (XP >= nextThreshold)
            {
                Level++;

                switch (Class)
                {
                    case "Warrior":
                        MaxHP += 6; ATK += 2; DEF += 2;
                        break;
                    case "Mage":
                        MaxHP += 4; ATK += 4; DEF += 1;
                        break;
                    case "Rogue":
                        MaxHP += 5; ATK += 3; DEF += 1;
                        break;
                }

                HP = MaxHP;

                Console.WriteLine($"Du når nivå {Level}! Värden ökade och HP återställd.");
            }
        }

      
        public void ShowStatus()
        {
            Console.WriteLine($"[{Name} | {Class}] HP {HP}/{MaxHP} ATK {ATK} DEF {DEF} LVL {Level} XP {XP} Guld {Gold} Drycker {Potions}");

            if (Inventory.Count > 0)
            {
                Console.WriteLine("Väska: " + string.Join(", ", Inventory));
            }
        }
        
        public bool SpendGold(int amount)
        {
            if (Gold < amount) return false;
            Gold -= amount;
            return true;
        }
        
        public void AddPotion(int amount)
        {
            Potions += amount;
        }

        public void IncreaseATK(int amount)
        {
            ATK += amount;
        }

        public void IncreaseDEF(int amount)
        {
            DEF += amount;
        }

        public void HealToMax()
        {
            HP = MaxHP;
        }
}

