﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace BlockGame.BlockWorld
{
	public struct GenerateRegion : IComponentData
	{
		public int2 regionIndex;
	} 
}
