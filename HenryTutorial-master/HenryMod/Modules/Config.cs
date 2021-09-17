﻿using BepInEx.Configuration;
using UnityEngine;

namespace HenryMod.Modules
{
    public static class Config
    {
        public static void ReadConfig()
        {
            Config.MiphaReadySound = HenryPlugin.instance.Config.Bind<bool>("Champion Ready Sounds", "Miphas Grace", true, "Enables the sound 'Mipha's Grace is Ready' when the cooldown is over.");
            Config.RevaliReadySound = HenryPlugin.instance.Config.Bind<bool>("Champion Ready Sounds", "Revalis Gale", true, "Enables the sound 'Revali's Gale is Ready' when the cooldown is over.");
            Config.UrbosaReadySound = HenryPlugin.instance.Config.Bind<bool>("Champion Ready Sounds", "Urbosas Fury", true, "Enables the sound 'Urbosa's Fury is Ready' when the cooldown is over.");
            Config.DarukReadySound = HenryPlugin.instance.Config.Bind<bool>("Champion Ready Sounds", "Daruks Protection", true, "Enables the sound 'Daruk's Protection is Ready to Roll' when the cooldown is over.");
        }

        // this helper automatically makes config entries for disabling survivors
        internal static ConfigEntry<bool> CharacterEnableConfig(string characterName)
        {
            return HenryPlugin.instance.Config.Bind<bool>(new ConfigDefinition(characterName, "Enabled"), true, new ConfigDescription("Set to false to disable this character"));
        }
        internal static ConfigEntry<bool> EnemyEnableConfig(string characterName)
        {
            return HenryPlugin.instance.Config.Bind<bool>(new ConfigDefinition(characterName, "Enabled"), true, new ConfigDescription("Set to false to disable this enemy"));
        }


        public static ConfigEntry<bool> CharacterEnabledConfig;
        public static ConfigEntry<bool> MiphaReadySound;
        public static ConfigEntry<bool> RevaliReadySound;
        public static ConfigEntry<bool> UrbosaReadySound;
        public static ConfigEntry<bool> DarukReadySound;
    }


}