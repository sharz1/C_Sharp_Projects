using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonsterClasses
{
    public partial class Default : System.Web.UI.Page
    {

        int damage;
        int defenderHealth;
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            Character hero = new Character();
            hero.Name = "Batman";
            hero.Health = 450;
            hero.DamageMaximum = 75;
            hero.AttackBonus = 100;

            Character monster = new Character()
            {
                Name = "Joker",
                Health = 400,
                DamageMaximum = 85,
                AttackBonus = 0
            };

            DisplayBattleStats(hero, monster);
            DisplayBattleStats(monster,hero);
        }
        private void DisplayBattleStats(Character attacker, Character defender)
        {
            damage = attacker.Attack();
            defender.Defend(damage);

            resultsLabel.Text += String.Format("<br />{0} attacks {1} with {2} damage, " +
                "bringing {1} health to: {3} <br />", attacker.Name, defender.Name, damage, defender.Health);
        }

    }
    class Character
    {
        Random random = new Random();

        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        public int Attack()
        {
            int damage = random.Next(1, DamageMaximum) + AttackBonus;
            return damage;
        }
        public void Defend(int damage)
        {
            Health -= damage;
        }

    }
}