namespace MuchBetterHotkeys
{

    using System.Collections.Generic;
    using System;

    public partial class PlayerHotkeyPatch
    {
        private static void QuickEquipHammer(Player player) {
            if (player.InPlaceMode() || Hud.IsPieceSelectionVisible()) {
                return;
            }
            Predicate<ItemDrop.ItemData> isHammer = delegate (ItemDrop.ItemData item) { return item.m_shared.m_name == "$item_hammer"; };
            List<ItemDrop.ItemData> hammers = player.m_inventory.m_inventory.FindAll(isHammer);
            hammers.Sort(new DurabilityComparer());
            if (hammers.Count > 0) {
                player.EquipItem(hammers[0]);
            }

        }
    }
}