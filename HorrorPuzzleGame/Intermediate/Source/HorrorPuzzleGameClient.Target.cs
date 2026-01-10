using UnrealBuildTool;

public class HorrorPuzzleGameClientTarget : TargetRules
{
	public HorrorPuzzleGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("HorrorPuzzleGame");
	}
}
