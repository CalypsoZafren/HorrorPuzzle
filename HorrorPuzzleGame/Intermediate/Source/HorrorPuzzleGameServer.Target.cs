using UnrealBuildTool;

public class HorrorPuzzleGameServerTarget : TargetRules
{
	public HorrorPuzzleGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("HorrorPuzzleGame");
	}
}
