using Ccc;
using Harmony;
using Pathea;
using Pathea.ModuleNs;
using Pathea.StoreNs;
using Pathea.UISystemNs;
using Pathea.UISystemNs.PlayUI;
using spacechase0.MiniModLoader.Api;
using spacechase0.MiniModLoader.Api.Events;
using spacechase0.MiniModLoader.Api.Mods;
using System;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MarketPriceUI
{
    public class Mod : IMod
    {
        public override void AfterModsLoaded()
        {
            Events.PlayerLeavesBed += playerLeftBed;
        }

        private static void playerLeftBed(object sender, EventArgs args)
        {
            var obj = GameObject.Find("/Canvas");
            obj.AddComponent<MarketPriceDisplay>();
        }
    }
}
