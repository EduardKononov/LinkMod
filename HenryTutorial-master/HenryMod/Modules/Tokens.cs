﻿using R2API;
using System;

namespace HenryMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Henry
            string prefix = HenryPlugin.developerPrefix + "_HENRY_BODY_";

            string desc = "Link is the Hero of Hyrule, weilder of the Triforce of Courage.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > The Master Sword is Link's primary weapon against the forces of evil." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > His bow allows Link to deal high damage at range." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Link's Sheikah Runes allow for a wide variety of utility options." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Link's Champion Abilities offer extra mobility, protection, high damage, or a second life." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he rested, the Kingdom of Hyrule saved.";
            string outroFailure = "..and so he vanished, the Kingdom of Hyrule left to ruin.";

            LanguageAPI.Add(prefix + "NAME", "Link");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Hero's Shade");
            LanguageAPI.Add(prefix + "LORE", "sample lore");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Hylian Set");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Champion's Tunic");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Paraglider");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "An item that you received from the king on the Great Plateau.\nIt allows you to sail through the sky.\nHold space while you're in the air to use it.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SWORD_NAME", "The Master Sword");
            LanguageAPI.Add(prefix + "PRIMARY_SWORD_DESCRIPTION", "The legendary sword that seals the darkness." + Helpers.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_BOW_NAME", "Royal Guard Bow");
            LanguageAPI.Add(prefix + "SECONDARY_BOW_DESCRIPTION", Helpers.agilePrefix + $"Loose an arrow for <style=cIsDamage>{100f * StaticValues.bowDamageCoefficient}% damage</style>.");

            LanguageAPI.Add(prefix + "SECONDARY_ROLL_NAME", "Roll");
            LanguageAPI.Add(prefix + "SECONDARY_ROLL_DESCRIPTION", Helpers.agilePrefix + "Become immune to damage and roll for a quick get away.");

            LanguageAPI.Add(prefix + "SECONDARY_3BOW_NAME", "Great Eagle Bow");
            LanguageAPI.Add(prefix + "SECONDARY_3BOW_DESCRIPTION", Helpers.agilePrefix + $"Loose three arrows at once, each dealing <style=cIsDamage>{33f * StaticValues.bowDamageCoefficient}%damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_BOMB_NAME", "Remote Bomb");
            LanguageAPI.Add(prefix + "UTILITY_BOMB_DESCRIPTION", $"A bomb that can be detonated remotely. After throwing, press again to detonate for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>");

            LanguageAPI.Add(prefix + "UTILITY_MAG_NAME", "Magnesis");
            LanguageAPI.Add(prefix + "UTILITY_MAG_DESCRIPTION", "Manipulate metallic objects using magnetism.");

            LanguageAPI.Add(prefix + "UTILITY_STAS_NAME", "Stasis");
            LanguageAPI.Add(prefix + "UTILITY_STAS_DESCRIPTION", "Stop the flow of time for an enemy.");

            LanguageAPI.Add(prefix + "UTILITY_CRY_NAME", "Cryonis");
            LanguageAPI.Add(prefix + "UTILITY_CRY_DESCRIPTION", "Create a pillar of ice.");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_MIPHA_NAME", "Mipha's Grace");
            LanguageAPI.Add(prefix + "SPECIAL_MIPHA_DESCRIPTION", "When your hearts run out, you'll automatically be resurrected with full health and three seconds of invincibility.");

            LanguageAPI.Add(prefix + "SPECIAL_DARUK_NAME", "Daruk's Protection");
            LanguageAPI.Add(prefix + "SPECIAL_DARUK_DESCRIPTION", "It will automatically protect you from all manner of attacks while you're holding R.");

            LanguageAPI.Add(prefix + "SPECIAL_REVALI_NAME", "Revali's Gale");
            LanguageAPI.Add(prefix + "SPECIAL_REVALI_DESCRIPTION", "Creates an upward draft that carries you into the sky.");

            LanguageAPI.Add(prefix + "SPECIAL_URBOSA_NAME", "Urbosa's Fury");
            LanguageAPI.Add(prefix + "SPECIAL_URBOSA_DESCRIPTION", $"Summons powerful lightning to the surrounding area.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Link: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Link, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Link: Mastery");
            #endregion
            #endregion
        }
    }
}