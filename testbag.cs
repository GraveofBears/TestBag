using BepInEx;
using ItemManager;
using UnityEngine;

namespace TestBallBag
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class ExampleMod : BaseUnityPlugin
    {
        private const string ModName = "TestBallBag";
        private const string ModVersion = "0.0.4";
        private const string ModGUID = "org.bepinex.plugins.testballbag";

        public void Awake()

        {
            Item testBag = new Item("testbag", "JC_Backpack");
            testBag.Crafting.Add(CraftingTable.Workbench, 1);
            testBag.RequiredItems.Add("Wood", 10);
            testBag.RequiredUpgradeItems.Add("Wood", 5);

        }

    }
 
}
