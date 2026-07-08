using UnrealBuildTool;

public class Parcial2Target : TargetRules
{
	public Parcial2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Parcial2");
	}
}
