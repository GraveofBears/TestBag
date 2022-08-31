using BepInEx;
using ItemManager;
using UnityEngine;
using KeyManager;

namespace TestBallBag
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    [KeyManager.VerifyKey("ModAuthor/ModName", LicenseMode.DedicatedServer)]
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

            Item testQuiv = new Item("testbag", "JC_Quiver");
            testQuiv.Crafting.Add(CraftingTable.Workbench, 1);
            testQuiv.RequiredItems.Add("Wood", 10);
            testQuiv.RequiredItems.Add("Iron", 5);
            testQuiv.RequiredUpgradeItems.Add("Iron", 2);

        }

    }
 
}