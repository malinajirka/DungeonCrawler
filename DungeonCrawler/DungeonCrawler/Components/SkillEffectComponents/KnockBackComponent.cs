﻿#region File Description
//-----------------------------------------------------------------------------
// KnockBackComponent.cs 
//
// Author: Nicholas Boen
// 
// Kansas State Univerisity CIS 580 Fall 2012 Dungeon Crawler Game
// Copyright (C) CIS 580 Fall 2012 Class. All rights reserved.
// Released under the Microsoft Permissive Licence 
//-----------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DungeonCrawler.Components
{
    public struct KnockBack
    {
        public uint EntityID;
        public uint TargetID;

        public Vector2 Origin;
        public float Distance;
    }

    public class KnockBackComponent : GameComponent<KnockBack>
    {
    }
}
