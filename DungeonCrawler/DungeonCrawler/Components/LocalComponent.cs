﻿#region File Description
//-----------------------------------------------------------------------------
// LocalComponent.cs 
//
// Author: Nathan Bean
//
// Kansas State Univerisity CIS 580 Fall 2012 Dungeon Crawler Game
// Copyright (C) CIS 580 Fall 2012 Class. All rights reserved.
// Released under the Microsoft Permissive Licence 
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System.Collections.Generic;
using Microsoft.Xna.Framework;
#endregion

namespace DungeonCrawler.Components
{
    /// <summary>
    /// A structure indicating the local nature of an entity
    /// </summary>
    public struct Local
    {
        /// <summary>
        /// The entity this Local component belongs to
        /// </summary>
        public uint EntityID;
    }

    /// <summary>
    /// The local components for all entities in a game world
    /// </summary>
    public class LocalComponent : GameComponent<Local>
    {

    }
}
