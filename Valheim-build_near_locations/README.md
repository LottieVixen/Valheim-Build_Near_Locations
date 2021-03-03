# Build in Protected Locations
A mod for Valheim to allow building in areas protected by "A mystical force in this area stops you" like the start area

# How to Contact me
If there is an issue with this mod you can contact me on the valheim modding [discord](https://discord.gg/RBq2mzeu4z) linked above,
Charlotte#0086,
just @ me with an issue,
please do not direct message me.

# Build instructions
add references to Harmony and BepInEx as well as UnityEngine and UnityEngine.CoreModule,
as well as assembly_valheim publicized then build, zip the resulting directory name appropriately and you're done :D

# What this mod does
uses harmony to attach a prefix function that bypasses `Location.IsInsideNoBuildLocation` and always returns false, to allow building!