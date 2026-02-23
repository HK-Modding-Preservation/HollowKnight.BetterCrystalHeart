using Satchel.BetterMenus;
using System;

namespace BetterCrystalHeart
{
    public static class ModMenu
    {
        private static Menu menu;
        private static MenuScreen menuScreen;

        /// <summary>
        /// Builds the Exaltation Expanded menu
        /// </summary>
        /// <param name="modListMenu"></param>
        /// <returns></returns>
        public static MenuScreen CreateMenuScreen(MenuScreen modListMenu)
        {
            // Declare the menu
            menu = new Menu("Better Crystal Heart Options", new Element[] { });

            // Populate main menu
            CustomSlider timeSlider = new CustomSlider("Charge Time Modifier",
                                                        value => BetterCrystalHeart.globalSettings.TimeModifier = value,
                                                        () => BetterCrystalHeart.globalSettings.TimeModifier, 
                                                        -100, 
                                                        100);
            CustomSlider damageSlider = new CustomSlider("Damage Modifier",
                                                        value => BetterCrystalHeart.globalSettings.DamageModifier = value,
                                                        () => BetterCrystalHeart.globalSettings.DamageModifier,
                                                        -100,
                                                        100);
            menu.AddElement(timeSlider);
            menu.AddElement(damageSlider);
            menu.AddElement(new HorizontalOption("Dynamic Damage Bonus",
                                "Synergy applied based on Dynamic Crystal Dash",
                                MenuValues(),
                                value => BetterCrystalHeart.globalSettings.DynamicModifier = Convert.ToBoolean(value),
                                () => Convert.ToInt32(BetterCrystalHeart.globalSettings.DynamicModifier)));
            menu.AddElement(new MenuButton("Reset", 
                                            "",
                                            submitAction => {
                                                BetterCrystalHeart.globalSettings.TimeModifier = 0;
                                                BetterCrystalHeart.globalSettings.DamageModifier = 0;
                                                timeSlider.Update();
                                                damageSlider.Update();
                                            }));

            // Insert the menu into the overall menu
            menuScreen = menu.GetMenuScreen(modListMenu);

            return menuScreen;
        }

        private static string[] MenuValues()
        {
            return new string[] { "OFF", "ON" };
        }
    }
}