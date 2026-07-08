using UnrealBuildTool;

public class Parcial2ClientTarget : TargetRules
{
	public Parcial2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Parcial2");
	}
}
