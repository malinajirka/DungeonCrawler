﻿﻿#region File Description
//-----------------------------------------------------------------------------
// EnemyAIComponent.cs 
//
// Author: Michael Fountain
//
// Kansas State Univerisity CIS 580 Fall 2012 Dungeon Crawler Game
// Copyright (C) CIS 580 Fall 2012 Class. All rights reserved.
// Released under the Microsoft Permissive Licence 
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
#endregion

namespace DungeonCrawler.Components
{
    public enum NPCType
    {
        Quest,
        Shopkeeper,
        Information,
        Background
    }

    public struct NpcAI
    {
        // <summary>
        /// The ID of the entity this AI belongs to
        /// </summary>
        public uint EntityID;

        /// <summary>
        /// Shows what type of NPC this is
        /// </summary>
        public NPCType Type;

    }

    public class NpcAIComponent : GameComponent<NpcAI>
    {

    }
}