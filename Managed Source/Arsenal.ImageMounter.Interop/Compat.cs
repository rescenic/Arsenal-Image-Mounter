﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

#if !NET5_0_OR_GREATER

[assembly: InternalsVisibleTo("Arsenal.ImageMounter, PublicKey=00240000048000009400000006020000002400005253413100040000010001005d35b93c619dfc2701e42022ab8d85c5b5c3e64bce4e1c017d1304f5383f0644b7e9b39e3443dffb8c53b5b7666945ee7b7af774137fda303d6619a4c2f87d1df9a5cd7edb302e1749a14e61bdd4d175fcbd4125b8f47505017a99c3b1dc87f7270d79f5d71e65026be700a48f886d12f1470456ff14884965eeffe876c2f2d7")]
[assembly: InternalsVisibleTo("Arsenal.ImageMounter.Devio, PublicKey=00240000048000009400000006020000002400005253413100040000010001005d35b93c619dfc2701e42022ab8d85c5b5c3e64bce4e1c017d1304f5383f0644b7e9b39e3443dffb8c53b5b7666945ee7b7af774137fda303d6619a4c2f87d1df9a5cd7edb302e1749a14e61bdd4d175fcbd4125b8f47505017a99c3b1dc87f7270d79f5d71e65026be700a48f886d12f1470456ff14884965eeffe876c2f2d7")]
[assembly: InternalsVisibleTo("Arsenal.ImageMounter.Devio.Interop, PublicKey=00240000048000009400000006020000002400005253413100040000010001005d35b93c619dfc2701e42022ab8d85c5b5c3e64bce4e1c017d1304f5383f0644b7e9b39e3443dffb8c53b5b7666945ee7b7af774137fda303d6619a4c2f87d1df9a5cd7edb302e1749a14e61bdd4d175fcbd4125b8f47505017a99c3b1dc87f7270d79f5d71e65026be700a48f886d12f1470456ff14884965eeffe876c2f2d7")]

namespace System.Runtime.Versioning;

//
// Summary:
//     Base type for all platform-specific API attributes.
internal abstract class OSPlatformAttribute : Attribute
{
    //
    // Summary:
    //     Gets the name and optional version of the platform that the attribute applies
    //     to.
    //
    // Returns:
    //     The applicable platform name and optional version.
    public string PlatformName
    {
        get;
    }

    private protected OSPlatformAttribute(string platformName)
    {
        PlatformName = platformName;
    }
}

//
// Summary:
//     Indicates that an API is supported for a specified platform or operating system.
//     If a version is specified, the API cannot be called from an earlier version.
//     Multiple attributes can be applied to indicate support on multiple operating
//     systems.
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
internal sealed class SupportedOSPlatformAttribute : OSPlatformAttribute
{
    //
    // Summary:
    //     Initializes a new instance of the System.Runtime.Versioning.SupportedOSPlatformAttribute
    //     attribute class for the specified supported OS platform.
    //
    // Parameters:
    //   platformName:
    //     The supported OS platform name, optionally including a version.
    public SupportedOSPlatformAttribute(string platformName)
        : base(platformName)
    {
    }
}

#endif
