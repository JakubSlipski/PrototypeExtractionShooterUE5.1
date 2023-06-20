using UnrealBuildTool;

public class Daybreaker_FalconerTarget : TargetRules
{
	public Daybreaker_FalconerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Daybreaker_Falconer");
	}
}
