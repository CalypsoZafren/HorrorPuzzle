using UnrealBuildTool;

public class HorrorPuzzleGameTarget : TargetRules
{
	public HorrorPuzzleGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HorrorPuzzleGame");
	}
}
