using UnrealBuildTool;

public class Parcial2EditorTarget : TargetRules
{
	public Parcial2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Parcial2");
	}
}
