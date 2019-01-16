using Pathea.ModuleNs;
using Pathea.StoreNs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace MarketPriceUI
{
    public class MarketPriceDisplay : MonoBehaviour
    {
        public void OnGUI()
        {
            var str = TextMgr.GetStr(250011); // Market Price:{0}
            str = string.Format(str, string.Format("{0:P0}", Module<StoreManagerV40>.Self.CurPriceIndex));

            GUI.Label(new Rect(5, 5, 150, 50), str);
        }
    }
}
