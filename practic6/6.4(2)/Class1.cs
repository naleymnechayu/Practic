using System;

namespace task
{
    class AllHero
    {
        protected int Id { get; private set; }
        protected string Name { get; set; }
        private List<string> heroName = new List<string> {"Anti-Mage", "Axe", "Bane", "Bloodseeker", "Crystal Maiden",
                                                 "Drow Ranger", "Earthshaker", "Juggernaut", "Mirana", "Morphling",
                                                 "Shadow Fiend", "Phantom Lancer", "Puck", "Pudge", "Razor",
                                                 "Sand King", "Storm Spirit", "Sven", "Tiny", "Vengeful Spirit",
                                                 "Windranger", "Zeus", "Kunkka", "Lina", "Lion",
                                                 "Shadow Shaman", "Slardar", "Tidehunter", "Witch Doctor", "Lich",
                                                 "Riki", "Enigma", "Tinker", "Sniper", "Necrophos",
                                                 "Warlock", "Beastmaster", "Queen of Pain", "Venomancer", "Faceless Void",
                                                 "Wraith King", "Death Prophet", "Phantom Assassin", "Pugna", "Templar Assassin",
                                                 "Viper", "Luna", "Dragon Knight", "Dazzle", "Clockwerk",
                                                 "Leshrac", "Nature's Prophet", "Lifestealer", "Dark Seer", "Clinkz",
                                                 "Omniknight", "Enchantress", "Huskar", "Night Stalker", "Broodmother",
                                                 "Bounty Hunter", "Weaver", "Jakiro", "Batrider", "Chen",
                                                 "Spectre", "Ancient Apparition", "Doom", "Ursa", "Spirit Breaker",
                                                 "Gyrocopter", "Alchemist", "Invoker", "Silencer", "Outworld Devourer",
                                                 "Lycan", "Brewmaster", "Shadow Demon", "Lone Druid", "Chaos Knight",
                                                 "Meepo", "Treant Protector", "Ogre Magi", "Undying", "Rubick",
                                                 "Disruptor", "Nyx Assassin", "Naga Siren", "Keeper of the Light", "Io",
                                                 "Visage", "Slark", "Medusa", "Troll Warlord", "Centaur Warrunner",
                                                 "Magnus", "Timbersaw", "Bristleback", "Tusk", "Skywrath Mage",
                                                 "Abaddon", "Elder Titan", "Legion Commander", "Techies", "Ember Spirit",
                                                 "Earth Spirit", "Underlord", "Terrorblade", "Phoenix", "Oracle",
                                                 "Winter Wyvern", "Arc Warden", "Monkey King", "Dark Willow", "Pangolier",
                                                 "Grimstroke", "Hoodwink", "Void Spirit", "Snapfire", "Mars", "Dawnbreaker" };
        public void AddElem(string elem)
        {
            heroName.Add(elem);
        }
        public void RemoveElem(string elem) 
        {  
            heroName.Remove(elem); 
        }
        protected List<string> SortedHerroList()
        {
            heroName.Sort();
            return heroName;
        }

        public void GetElem()
        {
            Id = -1;
            Name = "Input Error";
        }
        public void GetElem(string name)
        {
            SortedHerroList();
            for (int i = 0; i < heroName.Count; i++)
            {
                if (name == heroName[i])
                {
                    Id = i;
                }
            }
            Name = heroName[Id];
        }    
    }

    class HeroLore: txtHero
    {
        public void ShowLore()
        {
            foreach (KeyValuePair<int, string> hero in addinfoAbout())
            {
                Console.WriteLine($"Id - {hero.Key} Name - {Name}: {hero.Value}");
            }
        }
    }
}
