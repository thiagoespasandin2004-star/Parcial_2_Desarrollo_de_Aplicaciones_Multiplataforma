using UnrealBuildTool;

public class Parcial2ServerTarget : TargetRules
{
	public Parcial2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Parcial2");
	}
}
