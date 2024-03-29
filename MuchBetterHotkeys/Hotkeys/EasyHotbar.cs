﻿namespace MuchBetterHotkeys
{

    using UnityEngine;

    public partial class PlayerHotkeyPatch
    {
        private static bool EasyHotbar(Player player) {
            if (!Input.GetKey(MuchBetterHotkeys.easyHotbarPrefix.Value.MainKey)) {
                return true;
            }
            KeyCode[] keycodes = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4 };
            for (int idx = 0; idx < keycodes.Length; idx++) {
                KeyCode curKeyCode = keycodes[idx];
                if (Input.GetKeyDown(curKeyCode)) {
                    player.UseHotbarItem(idx + 5);
                    return false;
                }
            }
            return true;
        }
    }
}
