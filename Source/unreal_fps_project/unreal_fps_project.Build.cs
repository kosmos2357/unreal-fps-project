// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class unreal_fps_project : ModuleRules
{
	public unreal_fps_project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"unreal_fps_project",
			"unreal_fps_project/Variant_Platforming",
			"unreal_fps_project/Variant_Platforming/Animation",
			"unreal_fps_project/Variant_Combat",
			"unreal_fps_project/Variant_Combat/AI",
			"unreal_fps_project/Variant_Combat/Animation",
			"unreal_fps_project/Variant_Combat/Gameplay",
			"unreal_fps_project/Variant_Combat/Interfaces",
			"unreal_fps_project/Variant_Combat/UI",
			"unreal_fps_project/Variant_SideScrolling",
			"unreal_fps_project/Variant_SideScrolling/AI",
			"unreal_fps_project/Variant_SideScrolling/Gameplay",
			"unreal_fps_project/Variant_SideScrolling/Interfaces",
			"unreal_fps_project/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
