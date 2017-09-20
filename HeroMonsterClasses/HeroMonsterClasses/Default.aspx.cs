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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character
            {
                Name = "Batman",
                Health = 450,
                DamageMaximum = 65,
                AttackBonus = 80
            };

            Character monster = new Character()
            {
                Name = "Penguin",
                Health = 700,
                DamageMaximum = 95,
                AttackBonus = 0
            };

            Dice dice = new Dice();

            DisplayCharacterStats(hero);
            DisplayCharacterStats(monster);

            while (hero.Health > 0 && monster.Health > 0)
            {
                DisplayBattleStats(hero, monster, dice);
                DisplayBattleStats(monster, hero, dice);
            }
            DisplayResults(hero, monster);
        }
        private void DisplayCharacterStats(Character character)
        {
            resultsLabel.Text += String.Format("<p>Name: {0}<br />Health: {1}<br />DamageMaximum: {2}<br />AttackBonus: {3}</p>",
                character.Name,
                character.Health,
                character.DamageMaximum,
                character.AttackBonus);
        }

        private void DisplayBattleStats(Character attacker, Character defender, Dice dice)
        {
            damage = attacker.Attack(dice);
            defender.Defend(damage);

            resultsLabel.Text += String.Format("<br />{0} attacks {1} with {2} damage, " +
                "bringing {1} health to: {3} <br />", attacker.Name, defender.Name, damage, defender.Health);
        }
        private void DisplayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health > 0) resultsLabel.Text += String.Format("<br />{0} has vanquished {1}. Victory!",
                 opponent1.Name, opponent2.Name);
            else if (opponent2.Health > 0) resultsLabel.Text += String.Format("<br />{0} has vanquished {1}. Victory!",
                 opponent2.Name, opponent1.Name);
            else resultsLabel.Text += String.Format("<br />{0} and {1} have both perished in battle!",
                 opponent1.Name, opponent2.Name);
        }

    }
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        public int Attack(Dice dice)
        {

            dice.Sides = this.DamageMaximum;
            int damage = dice.Roll() + AttackBonus;
            return damage;
        }
        public void Defend(int damage)
        {
            Health -= damage;
        }

    }
    class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();

        public int Roll()
        {
            int roll = random.Next(Sides);
            return roll;
        }
    }
}