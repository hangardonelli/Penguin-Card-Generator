using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinCardGenerator
{
    class Item
    {
        public int paper_item_id { get; set; }
        public int type { get; set; }
        public int cost { get; set; }
        public bool is_member { get; set; }
        public string label { get; set; }
        public string prompt { get; set; }
        public int layer { get; set; }
        public string is_bait { get; set; }
        public string is_epf { get; set; }
        public string customDepth { get; set; }
        public string has_translations { get; set; }
        public string is_back { get; set; }
        public string has_back { get; set; }
        public string make_tour_guide { get; set; }
        public string make_secret_agent { get; set; }
        public string is_medal { get; set; }
        public string is_gift { get; set; }
        public string noPurchasePopup { get; set; }
        public string exclusive { get; set; }
        public string is_game_achievable { get; set; }

    }
}
