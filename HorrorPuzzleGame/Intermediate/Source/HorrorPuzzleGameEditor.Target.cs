using UnrealBuildTool;

public class HorrorPuzzleGameEditorTarget : TargetRules
{
	public HorrorPuzzleGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("HorrorPuzzleGame");
	}
}
