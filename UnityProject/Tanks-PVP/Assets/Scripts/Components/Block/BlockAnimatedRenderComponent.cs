﻿using Morpeh;
using UnityEngine;
using Unity.IL2CPP.CompilerServices;

[Il2CppSetOption(Option.NullChecks, false)]
[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
[Il2CppSetOption(Option.DivideByZeroChecks, false)]
[System.Serializable]
public struct BlockAnimatedRenderComponent : IComponent {
    public BlockAnimationContent content;
    public SpriteRenderer spriteRenderer;
    public int currentAnimationFrame;
}

public enum BlockAnimationContent {
    NONE,
    WATER
}